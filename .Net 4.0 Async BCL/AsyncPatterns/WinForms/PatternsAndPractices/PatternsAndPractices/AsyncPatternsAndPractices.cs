using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsAndPractices
{
    public partial class AsyncPatternsAndPractices : Form
    {
        public AsyncPatternsAndPractices()
        {
            InitializeComponent();

            // Create temp folder ready for file copying examples
            string tempAudioFolder = Path.Combine(Path.GetTempPath(), "AsyncPatterns");
            if (!Directory.Exists(tempAudioFolder)) Directory.CreateDirectory(tempAudioFolder);
            AudioTempFolder.Text = tempAudioFolder;

            DeleteAllFilesFromFolder(AudioTempFolder.Text);
        }

        private async void WhenAll_Click(object sender, EventArgs e)
        {
            ClearConsole(Console);
            UpdateConsole(Console, "When All", null);

            ClearNowPlaying();
            DeleteAllFilesFromFolder(AudioTempFolder.Text);

            // CodeSnippets - 01-WhenAll
            // setup all file copies
            List<string> filenamesToCopy = GetAllFilenamesToCopy();
            List<Task<string>> copyTasks = new List<Task<string>>();
            for (int nextIndex = 0; nextIndex < filenamesToCopy.Count; nextIndex++)
            {
                copyTasks.Add(CopyFileAsync(filenamesToCopy[nextIndex],
                                            Path.Combine(AudioTempFolder.Text, Path.GetFileName(filenamesToCopy[nextIndex])),
                                            null, null, true));
            }

            // Note - leave out call to WhenAll and track won't play - it hasn't copied yet!
            string[] filesCopied = await TaskEx.WhenAll(copyTasks);

            // Play first MP3 file copied
            PlayAudioTrack(filesCopied.First(name => name.EndsWith(".mp3")), Path.Combine(AudioTempFolder.Text, @"Silents - Demo - cover.png"));
        }

        private async void WhenAnyThrottled_Click(object sender, EventArgs e)
        {
            ClearConsole(Console);
            UpdateConsole(Console, "When Any - Throttled", null);

            ClearNowPlaying();
            DeleteAllFilesFromFolder(AudioTempFolder.Text);

            // CodeSnippets - 02-WhenAnyThrottled
            // sort by filename, excluding the filepath
            List<String> filenamesToCopy = GetAllFilenamesToCopy();
            filenamesToCopy.Sort((x, y) => String.Compare(Path.GetFileName(x), Path.GetFileName(y)));

            // maximum 4 copies at any time
            const int CONCURRENCY_LEVEL = 4;

            // setup initial tasks (we may have less than concurrency level, so we can't use a for ... loop)
            int nextIndex = 0;
            List<Task<string>> copyTasks = new List<Task<string>>();
            while (nextIndex < CONCURRENCY_LEVEL && nextIndex < filenamesToCopy.Count)
            {
                copyTasks.Add(CopyFileAsync(filenamesToCopy[nextIndex],
                                            Path.Combine(AudioTempFolder.Text, Path.GetFileName(filenamesToCopy[nextIndex])),
                                            GetThrottledFilenameLabel(nextIndex),
                                            GetThrottledProgressBar(nextIndex),
                                            true));
                nextIndex++;
            }

            // now start monitoring those tasks with WhenAny, adding a new task every time a running task completes
            string lastFlacFilenameCopied = String.Empty;
            while (copyTasks.Count > 0)
            {
                Task<string> copyTask = await TaskEx.WhenAny(copyTasks);
                if (copyTask.IsCompleted)
                {
                    copyTasks.Remove(copyTask);
                    if (nextIndex < filenamesToCopy.Count)
                    {
                        copyTasks.Add(CopyFileAsync(filenamesToCopy[nextIndex],
                                                    Path.Combine(AudioTempFolder.Text,
                                                                 Path.GetFileName(filenamesToCopy[nextIndex])),
                                                    GetThrottledFilenameLabel(nextIndex),
                                                    GetThrottledProgressBar(nextIndex),
                                                    true));
                        if (Path.GetExtension(filenamesToCopy[nextIndex]) == ".flac")
                            lastFlacFilenameCopied = Path.Combine(AudioTempFolder.Text,
                                                                  Path.GetFileName(filenamesToCopy[nextIndex]));
                        nextIndex++;
                    }
                }
            }
        }

        private async void WhenAnyFirstWins_Click(object sender, EventArgs e)
        {
            ClearConsole(Console);
            UpdateConsole(Console, "When Any - First Wins", null);

            ClearNowPlaying();
            DeleteAllFilesFromFolder(AudioTempFolder.Text);

            // CodeSnippets - 03-WhenAnyFirstWins            
            var cancelRemainingTasks = new CancellationTokenSource();

            Task<string> copyFileFlac = CopyFileAsync(
                Path.Combine(AudioSourceFolder.Text, @"Flac\Silents - Demo - 03 The Stones and The Sea.flac"),
                Path.Combine(AudioTempFolder.Text, @"Silents - Demo - 03 The Stones and The Sea.flac"),
                ProgressDetails1, ProgressBar1, false, cancelRemainingTasks.Token);

            Task<string> copyFileMP3 = CopyFileAsync(
                Path.Combine(AudioSourceFolder.Text, @"MP3\Silents - Demo - 03 The Stones and The Sea.mp3"),
                Path.Combine(AudioTempFolder.Text, @"Silents - Demo - 03 The Stones and The Sea.mp3"),
                ProgressDetails2, ProgressBar2, false, cancelRemainingTasks.Token);

            Task<string> copyFileOgg = CopyFileAsync(
                Path.Combine(AudioSourceFolder.Text, @"Ogg Vorbis\Silents - Demo - 03 The Stones and The Sea.ogg"),
                Path.Combine(AudioTempFolder.Text, @"Silents - Demo - 03 The Stones and The Sea.ogg"),
                ProgressDetails3, ProgressBar3, false, cancelRemainingTasks.Token);

            Task<string> copyFileAAC = CopyFileAsync(
                Path.Combine(AudioSourceFolder.Text, @"AAC\Silents - Demo - 03 The Stones and The Sea.m4a"),
                Path.Combine(AudioTempFolder.Text, @"Silents - Demo - 03 The Stones and The Sea.m4a"),
                ProgressDetails4, ProgressBar4, false, cancelRemainingTasks.Token);

            List<Task<string>> copyTasks = new List<Task<string>>() { copyFileAAC, copyFileMP3, copyFileFlac, copyFileOgg };

            var firstCopyTask = await TaskEx.WhenAny(copyTasks);
            cancelRemainingTasks.Cancel();

            PlayAudioTrack(firstCopyTask.Result, Path.Combine(AudioSourceFolder.Text, @"AAC\Silents - Demo - cover.png"));
        }

        private async void WhenAnyInterleaved_Click(object sender, EventArgs e)
        {
            ClearConsole(Console);
            UpdateConsole(Console, "When Any - Interleaved", null);

            ClearConsole(WhenAnyInterleavedConsole);
            UpdateConsole(WhenAnyInterleavedConsole, "When Any - MD5 validation", null);

            ClearNowPlaying();
            DeleteAllFilesFromFolder(AudioTempFolder.Text);

            // CodeSnippets - 04-WhenAnyInterleaved

            List<string> filenamesToCopy = GetAllFilenamesToCopy();

            List<Task<string>> copyTasks =
                (from filename in filenamesToCopy
                 select CopyFileAsync(filename,
                                      Path.Combine(AudioTempFolder.Text, Path.GetFileName(filename)),
                                      null, null, false,
                                      new CancellationToken())
                ).ToList();

            string lastAACFileCopied = String.Empty;
            while (copyTasks.Count > 0)
            {
                Task<string> copyTask = await TaskEx.WhenAny(copyTasks);
                copyTasks.Remove(copyTask);

                if (Path.GetExtension(copyTask.Result) == ".m4a")
                {
                    string message = (ValidateMD5(copyTask.Result, copyTask.Result + ".md5"))
                                         ? "MD5 valid : {0}"
                                         : "*** MD5 INVALID *** : {0}";
                    UpdateConsole(WhenAnyInterleavedConsole, message, Path.GetFileName(copyTask.Result));

                    lastAACFileCopied = copyTask.Result;
                }
            }
            PlayAudioTrack(lastAACFileCopied, Path.Combine(AudioTempFolder.Text, @"Silents - Demo - cover.png"));
        }

        private async void WhenAnyEarlyBailout_Click(object sender, EventArgs e)
        {
            ClearConsole(Console);
            UpdateConsole(Console, "When Any - Early Bailout", null);

            ClearConsole(WhenAnyEarlyBailoutConsole);
            UpdateConsole(WhenAnyEarlyBailoutConsole, "When Any - MD5 validation", null);

            ClearNowPlaying();
            DeleteAllFilesFromFolder(AudioTempFolder.Text);

            // CodeSnippets - 05-WhenAnyEarlyBailout

            List<string> filenamesToCopy = GetAllFilenamesToCopy();

            List<Task<string>> copyTasks =
                (from filename in filenamesToCopy
                 select CopyFileAsync(filename,
                                      Path.Combine(AudioTempFolder.Text, Path.GetFileName(filename)),
                                      null, null, false,
                                      new CancellationToken())
                ).ToList();

            string lastAACFileCopied = String.Empty;
            while (copyTasks.Count > 0)
            {
                Task<string> copyTask = await TaskEx.WhenAny(copyTasks);
                copyTasks.Remove(copyTask);

                if (Path.GetExtension(copyTask.Result) == ".m4a")
                {
                    string message = (ValidateMD5(copyTask.Result, copyTask.Result + ".md5"))
                                         ? "MD5 valid : {0}"
                                         : "*** MD5 INVALID *** : {0}";
                    UpdateConsole(WhenAnyInterleavedConsole, message, Path.GetFileName(copyTask.Result));

                    lastAACFileCopied = copyTask.Result;
                }
            }
            PlayAudioTrack(lastAACFileCopied, Path.Combine(AudioTempFolder.Text, @"Silents - Demo - cover.png"));
        }

        #region Async copy file method used in all the samples

        private async Task<System.String> CopyFileAsync(string sourceFilepath,
    string destFilepath,
    Label progDetails,
    ProgressBar progBar,
    bool pauseOnCompleteToShowFullProgressBar)
        {
            if (pauseOnCompleteToShowFullProgressBar) TaskEx.Delay(1000);

            UpdateProgess(progBar, 0, progDetails, "");
            using (FileStream sourceStream = File.Open(sourceFilepath, FileMode.Open))
            {
                using (FileStream destinationStream = File.Create(destFilepath + ".tmp"))
                {
                    UpdateProgess(progBar, 50, progDetails, "Copying " + Path.GetExtension(sourceFilepath));
                    UpdateConsole(Console, "Copying started : {0} ", Path.GetFileName(sourceFilepath));

                    await sourceStream.CopyToAsync(destinationStream, 4096);
                }
            }
            UpdateProgess(progBar, 100, progDetails, "Copy " + Path.GetExtension(sourceFilepath) + " complete.");
            UpdateConsole(Console, "Copy completed : {0} ", Path.GetFileName(sourceFilepath));

            File.Move(destFilepath + ".tmp", destFilepath);
            return destFilepath;
        }

        // Version with Cancellation support 


        private async Task<System.String> CopyFileAsync(string sourceFilepath,
            string destFilepath,
            Label progDetails,
            ProgressBar progBar,
            bool pauseOnCompleteToShowFullProgressBar,
            CancellationToken cancellationToken)
        {
            if (pauseOnCompleteToShowFullProgressBar) TaskEx.Delay(1000);
            try
            {
                UpdateProgess(progBar, 0, progDetails, "");
                using (FileStream sourceStream = File.Open(sourceFilepath, FileMode.Open))
                {
                    using (FileStream destinationStream = File.Create(destFilepath + ".tmp"))
                    {
                        UpdateProgess(progBar, 50, progDetails, "Copying " + Path.GetExtension(sourceFilepath));
                        UpdateConsole(Console, "Copying started : {0} ", Path.GetFileName(sourceFilepath));

                        await sourceStream.CopyToAsync(destinationStream, 4096, cancellationToken);
                    }
                }
                UpdateProgess(progBar, 100, progDetails, "Copy " + Path.GetExtension(sourceFilepath) + " complete.");
                UpdateConsole(Console, "Copy completed : {0} ", Path.GetFileName(sourceFilepath));

                File.Move(destFilepath + ".tmp", destFilepath);
                return destFilepath;
            }
            catch (OperationCanceledException)
            {
                UpdateProgess(progBar, 00, progDetails, "Copy " + Path.GetExtension(sourceFilepath) + " cancelled.");
                UpdateConsole(Console, "Copying cancelled : {0} ", Path.GetFileName(sourceFilepath));

                if (File.Exists(destFilepath + ".tmp")) File.Delete(destFilepath + ".tmp");
                return null;
            }
        }

        #endregion

        #region Helper methods

        private List<string>GetAllFilenamesToCopy()
        {
            var filenamesToCopy = new List<string>();
            foreach (var folder in Directory.EnumerateDirectories(AudioSourceFolder.Text))
            {
                foreach (var file in Directory.EnumerateFiles(folder))
                {
                    if ((Path.GetExtension(file) != ".png") ||
                        (Path.GetExtension(file) == ".png") && (!filenamesToCopy.Exists(f => f.EndsWith(".png"))))
                        filenamesToCopy.Add(file);
                }
            }
            return filenamesToCopy;
        }

        private void PlayAudioTrack(string trackToPlayfilepath,
            string albumArtfilePath)
        {
            NowPlayingArtwork.SizeMode = PictureBoxSizeMode.Zoom;
            WindowsMediaPlayerControl.settings.autoStart = false;
            WindowsMediaPlayerControl.settings.volume = 100;
            WindowsMediaPlayerControl.URL = trackToPlayfilepath;
            WindowsMediaPlayerControl.Ctlcontrols.play();
            LoadImageIntoPictureBoxWithoutLockingFile(NowPlayingArtwork, albumArtfilePath);
            TrackName.Text = Path.GetFileName(trackToPlayfilepath);
        }

        private void ClearNowPlaying()
        {
            WindowsMediaPlayerControl.Ctlcontrols.stop();
            WindowsMediaPlayerControl.URL = null;
        }

        private void DeleteAllFilesFromFolder(string filepath)
        {
            foreach (var file in Directory.GetFiles(filepath))
            {
                File.Delete(file);
            }
        }

        private void ClearConsole(TextBox con)
        {
            con.Text = String.Empty;
            con.Refresh();
        }

        private void UpdateConsole(TextBox con,
            string message,
            params object[] args)
        {
            if (args == null)
                con.Text += message + "\r\n";
            else
                con.Text += String.Format(message, args) + "\r\n";

            con.SelectionStart = con.Text.Length;
            con.ScrollToCaret();
            con.Refresh();
        }

        private void UpdateProgess(ProgressBar progBar, int percentComplete, Label progDetails, string message)
        {
            if (progDetails != null)
            {
                progDetails.Text = message;
                progDetails.Refresh();
            }
            if (progBar != null)
            {
                progBar.Value = percentComplete;
                progBar.Refresh();
            }
        }

        private Label GetThrottledFilenameLabel(int fileIndex)
        {
            int remainder = fileIndex % 4;
            switch (remainder)
            {
                case 0:
                    return ThrottledFilename1;
                case 1:
                    return ThrottledFilename2;
                case 2:
                    return ThrottledFilename3;
                case 3:
                    return ThrottledFilename4;
                default:
                    return null;
            }
        }

        private ProgressBar GetThrottledProgressBar(int fileIndex)
        {
            int remainder = fileIndex % 4;
            switch (remainder)
            {
                case 0:
                    return ThrottledProgressBar1;
                case 1:
                    return ThrottledProgressBar2;
                case 2:
                    return ThrottledProgressBar3;
                case 3:
                    return ThrottledProgressBar4;
                default:
                    return null;
            }
        }

        private void LoadImageIntoPictureBoxWithoutLockingFile(PictureBox pb,
            string filePath)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                byte[] imageBytes = File.ReadAllBytes(filePath);
                stream.Write(imageBytes, 0, imageBytes.Length);
                stream.Position = 0;

                pb.Image = Image.FromStream(stream);
            }
        }

        public bool ValidateMD5(string audioFilename, 
            string hashFilename)
        {
            var actualHash = CalculateMD5Hash(audioFilename);
            var streamReader = new StreamReader(hashFilename);
            string expectedHash = streamReader.ReadToEnd();
            streamReader.Close();

            return actualHash.ToLower().Trim() == expectedHash.ToLower().Trim();
        }

        private string CalculateMD5Hash(string audioFilename)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                using (var file = new FileStream(audioFilename, FileMode.Open, FileAccess.Read))
                {
                    byte[] retVal = md5.ComputeHash(file);
                    return BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }
        }

        #endregion

        #region Form events that aren't doing Async stuff

        private void AudioSourceFolderPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = "Select Audio Source Folder";
            FolderBrowserDialog.ShowNewFolderButton = true;
            FolderBrowserDialog.ShowDialog();

            if (!String.IsNullOrEmpty(FolderBrowserDialog.SelectedPath))
                AudioSourceFolder.Text = FolderBrowserDialog.SelectedPath;
        }

        private void AudioTempFolderPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = "Select Audio Temporary Files Folder";
            FolderBrowserDialog.ShowNewFolderButton = true;
            FolderBrowserDialog.ShowDialog();

            if (!String.IsNullOrEmpty(FolderBrowserDialog.SelectedPath))
                AudioTempFolder.Text = FolderBrowserDialog.SelectedPath;
        }

        #endregion

    }
}
