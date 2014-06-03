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

        }

        private async void WhenAnyThrottled_Click(object sender, EventArgs e)
        {

        }

        private async void WhenAnyFirstWins_Click(object sender, EventArgs e)
        {

        }

        private async void WhenAnyInterleaved_Click(object sender, EventArgs e)
        {

        }

        private async void WhenAnyEarlyBailout_Click(object sender, EventArgs e)
        {

        }

        #region Async copy file method used in all the samples

        private async Task<System.String> CopyFileAsync(string sourceFilepath,
            string destFilepath,
            Label progDetails,
            ProgressBar progBar,
            bool pauseOnCompleteToShowFullProgressBar)
        {
            if (pauseOnCompleteToShowFullProgressBar) await Task.Delay(1000);

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

        #endregion

        #region Helper methods

        private List<string> GetAllFilenamesToCopy()
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


        private void PlayAudiotrack(string trackToPlayfilepath,
            string albumArtfilePath)
        {
            NowPlayingArtwork.SizeMode = PictureBoxSizeMode.Zoom;
            WindowsMediaPlayerControl.settings.autoStart = false;
            WindowsMediaPlayerControl.settings.volume = 100;
            WindowsMediaPlayerControl.URL = @"C:\Source\NDCOslo-AsyncPatterns\.Net 4.5\AsyncPatterns\Audio\Other\You've Been Rick Rolled.mp3";
            WindowsMediaPlayerControl.Ctlcontrols.play();
            LoadImageIntoPictureBoxWithoutLockingFile(NowPlayingArtwork, @"C:\Source\NDCOslo-AsyncPatterns\.Net 4.5\AsyncPatterns\Audio\Other\rickrolled01.jpg");
            TrackName.Text = "You've been Rick Rolled!";
        }

        #endregion

    }
}
