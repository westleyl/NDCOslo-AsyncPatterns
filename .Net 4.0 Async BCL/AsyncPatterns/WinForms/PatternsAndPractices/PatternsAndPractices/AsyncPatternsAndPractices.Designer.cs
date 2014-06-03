namespace PatternsAndPractices
{
    partial class AsyncPatternsAndPractices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsyncPatternsAndPractices));
            this.ConfLogo = new System.Windows.Forms.PictureBox();
            this.NowPlayingLabel = new System.Windows.Forms.Label();
            this.NowPlayingArtwork = new System.Windows.Forms.PictureBox();
            this.WindowsMediaPlayerControl = new AxWMPLib.AxWindowsMediaPlayer();
            this.ConferenceTitle = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.TextBox();
            this.TrackName = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.PictureBox();
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.TabConfiguration = new System.Windows.Forms.TabPage();
            this.AudioTempFolderPicker = new System.Windows.Forms.Button();
            this.AudioSourceFolderPicker = new System.Windows.Forms.Button();
            this.AudioSourceFolder = new System.Windows.Forms.TextBox();
            this.AudioTempFolder = new System.Windows.Forms.TextBox();
            this.AudioTemporaryFolderLabel = new System.Windows.Forms.Label();
            this.AudioSourceFolderLabel = new System.Windows.Forms.Label();
            this.TabWhenAll = new System.Windows.Forms.TabPage();
            this.WhenAllDescription = new System.Windows.Forms.Label();
            this.WhenAll = new System.Windows.Forms.Button();
            this.TabWhenAnyThrottled = new System.Windows.Forms.TabPage();
            this.WhenAnyThrottledTip = new System.Windows.Forms.Label();
            this.ThrottledProgressBar4 = new System.Windows.Forms.ProgressBar();
            this.ThrottledProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.ThrottledProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.ThrottledProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ThrottledFilename4 = new System.Windows.Forms.Label();
            this.ThrottledFilename3 = new System.Windows.Forms.Label();
            this.ThrottledFilename2 = new System.Windows.Forms.Label();
            this.ThrottledFilename1 = new System.Windows.Forms.Label();
            this.WhenAnyThrottled = new System.Windows.Forms.Button();
            this.TabWhenAnyFirst = new System.Windows.Forms.TabPage();
            this.WhenAnyFirstTip = new System.Windows.Forms.Label();
            this.WhenAnyFirstWins = new System.Windows.Forms.Button();
            this.ProgressBar4 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressDetails4 = new System.Windows.Forms.Label();
            this.ProgressDetails3 = new System.Windows.Forms.Label();
            this.ProgressDetails2 = new System.Windows.Forms.Label();
            this.ProgressDetails1 = new System.Windows.Forms.Label();
            this.TabWhenAnyInterleaved = new System.Windows.Forms.TabPage();
            this.WhenAnyInterleavedConsole = new System.Windows.Forms.TextBox();
            this.WhenAnyInterleaved = new System.Windows.Forms.Button();
            this.TabWhenAnyEarlyBailout = new System.Windows.Forms.TabPage();
            this.WhenAnyEarlyBailoutInstruction = new System.Windows.Forms.Label();
            this.WhenAnyEarlyBailoutConsole = new System.Windows.Forms.TextBox();
            this.WhenAnyEarlyBailout = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ConfLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowPlayingArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divider)).BeginInit();
            this.AllTabs.SuspendLayout();
            this.TabConfiguration.SuspendLayout();
            this.TabWhenAll.SuspendLayout();
            this.TabWhenAnyThrottled.SuspendLayout();
            this.TabWhenAnyFirst.SuspendLayout();
            this.TabWhenAnyInterleaved.SuspendLayout();
            this.TabWhenAnyEarlyBailout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfLogo
            // 
            this.ConfLogo.Image = ((System.Drawing.Image)(resources.GetObject("ConfLogo.Image")));
            this.ConfLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ConfLogo.InitialImage")));
            this.ConfLogo.Location = new System.Drawing.Point(345, 12);
            this.ConfLogo.Name = "ConfLogo";
            this.ConfLogo.Size = new System.Drawing.Size(172, 160);
            this.ConfLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ConfLogo.TabIndex = 0;
            this.ConfLogo.TabStop = false;
            this.ConfLogo.WaitOnLoad = true;
            // 
            // NowPlayingLabel
            // 
            this.NowPlayingLabel.AutoSize = true;
            this.NowPlayingLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingLabel.Location = new System.Drawing.Point(7, 200);
            this.NowPlayingLabel.Name = "NowPlayingLabel";
            this.NowPlayingLabel.Size = new System.Drawing.Size(119, 26);
            this.NowPlayingLabel.TabIndex = 1;
            this.NowPlayingLabel.Text = "Now Playing";
            // 
            // NowPlayingArtwork
            // 
            this.NowPlayingArtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NowPlayingArtwork.Location = new System.Drawing.Point(12, 12);
            this.NowPlayingArtwork.Name = "NowPlayingArtwork";
            this.NowPlayingArtwork.Size = new System.Drawing.Size(180, 180);
            this.NowPlayingArtwork.TabIndex = 2;
            this.NowPlayingArtwork.TabStop = false;
            // 
            // WindowsMediaPlayerControl
            // 
            this.WindowsMediaPlayerControl.Enabled = true;
            this.WindowsMediaPlayerControl.Location = new System.Drawing.Point(198, 149);
            this.WindowsMediaPlayerControl.Name = "WindowsMediaPlayerControl";
            this.WindowsMediaPlayerControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayerControl.OcxState")));
            this.WindowsMediaPlayerControl.Size = new System.Drawing.Size(114, 43);
            this.WindowsMediaPlayerControl.TabIndex = 4;
            // 
            // ConferenceTitle
            // 
            this.ConferenceTitle.AutoSize = true;
            this.ConferenceTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConferenceTitle.Location = new System.Drawing.Point(335, 175);
            this.ConferenceTitle.Name = "ConferenceTitle";
            this.ConferenceTitle.Size = new System.Drawing.Size(198, 26);
            this.ConferenceTitle.TabIndex = 5;
            this.ConferenceTitle.Text = "DDD East Anglia 2013";
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Console.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.Location = new System.Drawing.Point(11, 463);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(518, 141);
            this.Console.TabIndex = 6;
            // 
            // TrackName
            // 
            this.TrackName.AutoSize = true;
            this.TrackName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackName.Location = new System.Drawing.Point(7, 226);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(130, 26);
            this.TrackName.TabIndex = 7;
            this.TrackName.Text = "<Track name>";
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.Location = new System.Drawing.Point(11, 255);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(517, 2);
            this.Divider.TabIndex = 9;
            this.Divider.TabStop = false;
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.TabConfiguration);
            this.AllTabs.Controls.Add(this.TabWhenAll);
            this.AllTabs.Controls.Add(this.TabWhenAnyThrottled);
            this.AllTabs.Controls.Add(this.TabWhenAnyFirst);
            this.AllTabs.Controls.Add(this.TabWhenAnyInterleaved);
            this.AllTabs.Controls.Add(this.TabWhenAnyEarlyBailout);
            this.AllTabs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTabs.Location = new System.Drawing.Point(11, 263);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(518, 194);
            this.AllTabs.TabIndex = 12;
            // 
            // TabConfiguration
            // 
            this.TabConfiguration.Controls.Add(this.AudioTempFolderPicker);
            this.TabConfiguration.Controls.Add(this.AudioSourceFolderPicker);
            this.TabConfiguration.Controls.Add(this.AudioSourceFolder);
            this.TabConfiguration.Controls.Add(this.AudioTempFolder);
            this.TabConfiguration.Controls.Add(this.AudioTemporaryFolderLabel);
            this.TabConfiguration.Controls.Add(this.AudioSourceFolderLabel);
            this.TabConfiguration.Location = new System.Drawing.Point(4, 27);
            this.TabConfiguration.Name = "TabConfiguration";
            this.TabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfiguration.Size = new System.Drawing.Size(510, 163);
            this.TabConfiguration.TabIndex = 0;
            this.TabConfiguration.Text = "Configuration";
            this.TabConfiguration.UseVisualStyleBackColor = true;
            // 
            // AudioTempFolderPicker
            // 
            this.AudioTempFolderPicker.Location = new System.Drawing.Point(479, 74);
            this.AudioTempFolderPicker.Name = "AudioTempFolderPicker";
            this.AudioTempFolderPicker.Size = new System.Drawing.Size(28, 24);
            this.AudioTempFolderPicker.TabIndex = 20;
            this.AudioTempFolderPicker.Text = "...";
            this.AudioTempFolderPicker.UseVisualStyleBackColor = true;
            this.AudioTempFolderPicker.Click += new System.EventHandler(this.AudioTempFolderPicker_Click);
            // 
            // AudioSourceFolderPicker
            // 
            this.AudioSourceFolderPicker.Location = new System.Drawing.Point(479, 29);
            this.AudioSourceFolderPicker.Name = "AudioSourceFolderPicker";
            this.AudioSourceFolderPicker.Size = new System.Drawing.Size(28, 24);
            this.AudioSourceFolderPicker.TabIndex = 19;
            this.AudioSourceFolderPicker.Text = "...";
            this.AudioSourceFolderPicker.UseVisualStyleBackColor = true;
            this.AudioSourceFolderPicker.Click += new System.EventHandler(this.AudioSourceFolderPicker_Click);
            // 
            // AudioSourceFolder
            // 
            this.AudioSourceFolder.Location = new System.Drawing.Point(10, 29);
            this.AudioSourceFolder.Name = "AudioSourceFolder";
            this.AudioSourceFolder.Size = new System.Drawing.Size(463, 26);
            this.AudioSourceFolder.TabIndex = 18;
            this.AudioSourceFolder.Text = "C:\\source\\DDDEA\\AsyncPatterns\\Audio\\Silents - Demo";
            // 
            // AudioTempFolder
            // 
            this.AudioTempFolder.Location = new System.Drawing.Point(10, 74);
            this.AudioTempFolder.Name = "AudioTempFolder";
            this.AudioTempFolder.Size = new System.Drawing.Size(463, 26);
            this.AudioTempFolder.TabIndex = 17;
            // 
            // AudioTemporaryFolderLabel
            // 
            this.AudioTemporaryFolderLabel.AutoSize = true;
            this.AudioTemporaryFolderLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.AudioTemporaryFolderLabel.Location = new System.Drawing.Point(6, 52);
            this.AudioTemporaryFolderLabel.Name = "AudioTemporaryFolderLabel";
            this.AudioTemporaryFolderLabel.Size = new System.Drawing.Size(125, 19);
            this.AudioTemporaryFolderLabel.TabIndex = 16;
            this.AudioTemporaryFolderLabel.Text = "Audio temp folder";
            // 
            // AudioSourceFolderLabel
            // 
            this.AudioSourceFolderLabel.AutoSize = true;
            this.AudioSourceFolderLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.AudioSourceFolderLabel.Location = new System.Drawing.Point(6, 7);
            this.AudioSourceFolderLabel.Name = "AudioSourceFolderLabel";
            this.AudioSourceFolderLabel.Size = new System.Drawing.Size(137, 19);
            this.AudioSourceFolderLabel.TabIndex = 15;
            this.AudioSourceFolderLabel.Text = "Audio Source Folder";
            // 
            // TabWhenAll
            // 
            this.TabWhenAll.Controls.Add(this.WhenAllDescription);
            this.TabWhenAll.Controls.Add(this.WhenAll);
            this.TabWhenAll.Location = new System.Drawing.Point(4, 27);
            this.TabWhenAll.Name = "TabWhenAll";
            this.TabWhenAll.Padding = new System.Windows.Forms.Padding(3);
            this.TabWhenAll.Size = new System.Drawing.Size(510, 163);
            this.TabWhenAll.TabIndex = 1;
            this.TabWhenAll.Text = "WhenAll";
            this.TabWhenAll.UseVisualStyleBackColor = true;
            // 
            // WhenAllDescription
            // 
            this.WhenAllDescription.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAllDescription.Location = new System.Drawing.Point(6, 3);
            this.WhenAllDescription.Name = "WhenAllDescription";
            this.WhenAllDescription.Size = new System.Drawing.Size(501, 107);
            this.WhenAllDescription.TabIndex = 21;
            this.WhenAllDescription.Text = resources.GetString("WhenAllDescription.Text");
            // 
            // WhenAll
            // 
            this.WhenAll.Location = new System.Drawing.Point(10, 125);
            this.WhenAll.Name = "WhenAll";
            this.WhenAll.Size = new System.Drawing.Size(160, 30);
            this.WhenAll.TabIndex = 20;
            this.WhenAll.Text = "WhenAll (files copied)";
            this.WhenAll.UseVisualStyleBackColor = true;
            this.WhenAll.Click += new System.EventHandler(this.WhenAll_Click);
            // 
            // TabWhenAnyThrottled
            // 
            this.TabWhenAnyThrottled.Controls.Add(this.WhenAnyThrottledTip);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledProgressBar4);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledProgressBar3);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledProgressBar2);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledProgressBar1);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledFilename4);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledFilename3);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledFilename2);
            this.TabWhenAnyThrottled.Controls.Add(this.ThrottledFilename1);
            this.TabWhenAnyThrottled.Controls.Add(this.WhenAnyThrottled);
            this.TabWhenAnyThrottled.Location = new System.Drawing.Point(4, 27);
            this.TabWhenAnyThrottled.Name = "TabWhenAnyThrottled";
            this.TabWhenAnyThrottled.Size = new System.Drawing.Size(510, 163);
            this.TabWhenAnyThrottled.TabIndex = 3;
            this.TabWhenAnyThrottled.Text = "WhenAny - Throttled";
            this.TabWhenAnyThrottled.UseVisualStyleBackColor = true;
            // 
            // WhenAnyThrottledTip
            // 
            this.WhenAnyThrottledTip.AutoSize = true;
            this.WhenAnyThrottledTip.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAnyThrottledTip.Location = new System.Drawing.Point(189, 128);
            this.WhenAnyThrottledTip.Name = "WhenAnyThrottledTip";
            this.WhenAnyThrottledTip.Size = new System.Drawing.Size(303, 23);
            this.WhenAnyThrottledTip.TabIndex = 27;
            this.WhenAnyThrottledTip.Text = "Browse to temp folder before clicking!";
            // 
            // ThrottledProgressBar4
            // 
            this.ThrottledProgressBar4.Location = new System.Drawing.Point(185, 102);
            this.ThrottledProgressBar4.Name = "ThrottledProgressBar4";
            this.ThrottledProgressBar4.Size = new System.Drawing.Size(300, 15);
            this.ThrottledProgressBar4.TabIndex = 23;
            // 
            // ThrottledProgressBar3
            // 
            this.ThrottledProgressBar3.Location = new System.Drawing.Point(185, 73);
            this.ThrottledProgressBar3.Name = "ThrottledProgressBar3";
            this.ThrottledProgressBar3.Size = new System.Drawing.Size(300, 15);
            this.ThrottledProgressBar3.TabIndex = 24;
            // 
            // ThrottledProgressBar2
            // 
            this.ThrottledProgressBar2.Location = new System.Drawing.Point(185, 42);
            this.ThrottledProgressBar2.Name = "ThrottledProgressBar2";
            this.ThrottledProgressBar2.Size = new System.Drawing.Size(300, 15);
            this.ThrottledProgressBar2.TabIndex = 25;
            // 
            // ThrottledProgressBar1
            // 
            this.ThrottledProgressBar1.Location = new System.Drawing.Point(185, 13);
            this.ThrottledProgressBar1.Name = "ThrottledProgressBar1";
            this.ThrottledProgressBar1.Size = new System.Drawing.Size(300, 15);
            this.ThrottledProgressBar1.TabIndex = 26;
            // 
            // ThrottledFilename4
            // 
            this.ThrottledFilename4.AutoSize = true;
            this.ThrottledFilename4.Font = new System.Drawing.Font("Calibri", 12F);
            this.ThrottledFilename4.Location = new System.Drawing.Point(6, 96);
            this.ThrottledFilename4.Name = "ThrottledFilename4";
            this.ThrottledFilename4.Size = new System.Drawing.Size(81, 19);
            this.ThrottledFilename4.TabIndex = 19;
            this.ThrottledFilename4.Text = "<filename>";
            // 
            // ThrottledFilename3
            // 
            this.ThrottledFilename3.AutoSize = true;
            this.ThrottledFilename3.Font = new System.Drawing.Font("Calibri", 12F);
            this.ThrottledFilename3.Location = new System.Drawing.Point(6, 67);
            this.ThrottledFilename3.Name = "ThrottledFilename3";
            this.ThrottledFilename3.Size = new System.Drawing.Size(81, 19);
            this.ThrottledFilename3.TabIndex = 20;
            this.ThrottledFilename3.Text = "<filename>";
            // 
            // ThrottledFilename2
            // 
            this.ThrottledFilename2.AutoSize = true;
            this.ThrottledFilename2.Font = new System.Drawing.Font("Calibri", 12F);
            this.ThrottledFilename2.Location = new System.Drawing.Point(6, 38);
            this.ThrottledFilename2.Name = "ThrottledFilename2";
            this.ThrottledFilename2.Size = new System.Drawing.Size(81, 19);
            this.ThrottledFilename2.TabIndex = 21;
            this.ThrottledFilename2.Text = "<filename>";
            // 
            // ThrottledFilename1
            // 
            this.ThrottledFilename1.AutoSize = true;
            this.ThrottledFilename1.Font = new System.Drawing.Font("Calibri", 12F);
            this.ThrottledFilename1.Location = new System.Drawing.Point(6, 10);
            this.ThrottledFilename1.Name = "ThrottledFilename1";
            this.ThrottledFilename1.Size = new System.Drawing.Size(81, 19);
            this.ThrottledFilename1.TabIndex = 22;
            this.ThrottledFilename1.Text = "<filename>";
            // 
            // WhenAnyThrottled
            // 
            this.WhenAnyThrottled.Location = new System.Drawing.Point(10, 125);
            this.WhenAnyThrottled.Name = "WhenAnyThrottled";
            this.WhenAnyThrottled.Size = new System.Drawing.Size(160, 30);
            this.WhenAnyThrottled.TabIndex = 12;
            this.WhenAnyThrottled.Text = "WhenAny - Throttled";
            this.WhenAnyThrottled.UseVisualStyleBackColor = true;
            this.WhenAnyThrottled.Click += new System.EventHandler(this.WhenAnyThrottled_Click);
            // 
            // TabWhenAnyFirst
            // 
            this.TabWhenAnyFirst.Controls.Add(this.WhenAnyFirstTip);
            this.TabWhenAnyFirst.Controls.Add(this.WhenAnyFirstWins);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressBar4);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressBar3);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressBar2);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressBar1);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressDetails4);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressDetails3);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressDetails2);
            this.TabWhenAnyFirst.Controls.Add(this.ProgressDetails1);
            this.TabWhenAnyFirst.Location = new System.Drawing.Point(4, 27);
            this.TabWhenAnyFirst.Name = "TabWhenAnyFirst";
            this.TabWhenAnyFirst.Size = new System.Drawing.Size(510, 163);
            this.TabWhenAnyFirst.TabIndex = 2;
            this.TabWhenAnyFirst.Text = "WhenAny - First";
            this.TabWhenAnyFirst.UseVisualStyleBackColor = true;
            // 
            // WhenAnyFirstTip
            // 
            this.WhenAnyFirstTip.AutoSize = true;
            this.WhenAnyFirstTip.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAnyFirstTip.Location = new System.Drawing.Point(189, 128);
            this.WhenAnyFirstTip.Name = "WhenAnyFirstTip";
            this.WhenAnyFirstTip.Size = new System.Drawing.Size(303, 23);
            this.WhenAnyFirstTip.TabIndex = 20;
            this.WhenAnyFirstTip.Text = "Browse to temp folder before clicking!";
            // 
            // WhenAnyFirstWins
            // 
            this.WhenAnyFirstWins.Location = new System.Drawing.Point(10, 125);
            this.WhenAnyFirstWins.Name = "WhenAnyFirstWins";
            this.WhenAnyFirstWins.Size = new System.Drawing.Size(160, 30);
            this.WhenAnyFirstWins.TabIndex = 19;
            this.WhenAnyFirstWins.Text = "WhenAny - First Wins";
            this.WhenAnyFirstWins.UseVisualStyleBackColor = true;
            this.WhenAnyFirstWins.Click += new System.EventHandler(this.WhenAnyFirstWins_Click);
            // 
            // ProgressBar4
            // 
            this.ProgressBar4.Location = new System.Drawing.Point(185, 102);
            this.ProgressBar4.Name = "ProgressBar4";
            this.ProgressBar4.Size = new System.Drawing.Size(300, 15);
            this.ProgressBar4.TabIndex = 15;
            // 
            // ProgressBar3
            // 
            this.ProgressBar3.Location = new System.Drawing.Point(185, 73);
            this.ProgressBar3.Name = "ProgressBar3";
            this.ProgressBar3.Size = new System.Drawing.Size(300, 15);
            this.ProgressBar3.TabIndex = 16;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(185, 42);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(300, 15);
            this.ProgressBar2.TabIndex = 17;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(185, 13);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(300, 15);
            this.ProgressBar1.TabIndex = 18;
            // 
            // ProgressDetails4
            // 
            this.ProgressDetails4.AutoSize = true;
            this.ProgressDetails4.Font = new System.Drawing.Font("Calibri", 12F);
            this.ProgressDetails4.Location = new System.Drawing.Point(9, 99);
            this.ProgressDetails4.Name = "ProgressDetails4";
            this.ProgressDetails4.Size = new System.Drawing.Size(119, 19);
            this.ProgressDetails4.TabIndex = 11;
            this.ProgressDetails4.Text = "ProgressDetails4";
            // 
            // ProgressDetails3
            // 
            this.ProgressDetails3.AutoSize = true;
            this.ProgressDetails3.Font = new System.Drawing.Font("Calibri", 12F);
            this.ProgressDetails3.Location = new System.Drawing.Point(9, 70);
            this.ProgressDetails3.Name = "ProgressDetails3";
            this.ProgressDetails3.Size = new System.Drawing.Size(119, 19);
            this.ProgressDetails3.TabIndex = 12;
            this.ProgressDetails3.Text = "ProgressDetails3";
            // 
            // ProgressDetails2
            // 
            this.ProgressDetails2.AutoSize = true;
            this.ProgressDetails2.Font = new System.Drawing.Font("Calibri", 12F);
            this.ProgressDetails2.Location = new System.Drawing.Point(9, 41);
            this.ProgressDetails2.Name = "ProgressDetails2";
            this.ProgressDetails2.Size = new System.Drawing.Size(119, 19);
            this.ProgressDetails2.TabIndex = 13;
            this.ProgressDetails2.Text = "ProgressDetails2";
            // 
            // ProgressDetails1
            // 
            this.ProgressDetails1.AutoSize = true;
            this.ProgressDetails1.Font = new System.Drawing.Font("Calibri", 12F);
            this.ProgressDetails1.Location = new System.Drawing.Point(9, 13);
            this.ProgressDetails1.Name = "ProgressDetails1";
            this.ProgressDetails1.Size = new System.Drawing.Size(119, 19);
            this.ProgressDetails1.TabIndex = 14;
            this.ProgressDetails1.Text = "ProgressDetails1";
            // 
            // TabWhenAnyInterleaved
            // 
            this.TabWhenAnyInterleaved.Controls.Add(this.WhenAnyInterleavedConsole);
            this.TabWhenAnyInterleaved.Controls.Add(this.WhenAnyInterleaved);
            this.TabWhenAnyInterleaved.Location = new System.Drawing.Point(4, 27);
            this.TabWhenAnyInterleaved.Name = "TabWhenAnyInterleaved";
            this.TabWhenAnyInterleaved.Size = new System.Drawing.Size(510, 163);
            this.TabWhenAnyInterleaved.TabIndex = 4;
            this.TabWhenAnyInterleaved.Text = "WhenAny - Interleaved";
            this.TabWhenAnyInterleaved.UseVisualStyleBackColor = true;
            // 
            // WhenAnyInterleavedConsole
            // 
            this.WhenAnyInterleavedConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WhenAnyInterleavedConsole.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAnyInterleavedConsole.Location = new System.Drawing.Point(5, 5);
            this.WhenAnyInterleavedConsole.Multiline = true;
            this.WhenAnyInterleavedConsole.Name = "WhenAnyInterleavedConsole";
            this.WhenAnyInterleavedConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WhenAnyInterleavedConsole.Size = new System.Drawing.Size(500, 115);
            this.WhenAnyInterleavedConsole.TabIndex = 14;
            // 
            // WhenAnyInterleaved
            // 
            this.WhenAnyInterleaved.Location = new System.Drawing.Point(10, 125);
            this.WhenAnyInterleaved.Name = "WhenAnyInterleaved";
            this.WhenAnyInterleaved.Size = new System.Drawing.Size(160, 30);
            this.WhenAnyInterleaved.TabIndex = 13;
            this.WhenAnyInterleaved.Text = "WhenAny - Interleaved";
            this.WhenAnyInterleaved.UseVisualStyleBackColor = true;
            this.WhenAnyInterleaved.Click += new System.EventHandler(this.WhenAnyInterleaved_Click);
            // 
            // TabWhenAnyEarlyBailout
            // 
            this.TabWhenAnyEarlyBailout.Controls.Add(this.WhenAnyEarlyBailoutInstruction);
            this.TabWhenAnyEarlyBailout.Controls.Add(this.WhenAnyEarlyBailoutConsole);
            this.TabWhenAnyEarlyBailout.Controls.Add(this.WhenAnyEarlyBailout);
            this.TabWhenAnyEarlyBailout.Location = new System.Drawing.Point(4, 27);
            this.TabWhenAnyEarlyBailout.Name = "TabWhenAnyEarlyBailout";
            this.TabWhenAnyEarlyBailout.Size = new System.Drawing.Size(510, 163);
            this.TabWhenAnyEarlyBailout.TabIndex = 5;
            this.TabWhenAnyEarlyBailout.Text = "WhenAny - Early Bailout";
            this.TabWhenAnyEarlyBailout.UseVisualStyleBackColor = true;
            // 
            // WhenAnyEarlyBailoutInstruction
            // 
            this.WhenAnyEarlyBailoutInstruction.AutoSize = true;
            this.WhenAnyEarlyBailoutInstruction.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAnyEarlyBailoutInstruction.Location = new System.Drawing.Point(190, 131);
            this.WhenAnyEarlyBailoutInstruction.Name = "WhenAnyEarlyBailoutInstruction";
            this.WhenAnyEarlyBailoutInstruction.Size = new System.Drawing.Size(323, 21);
            this.WhenAnyEarlyBailoutInstruction.TabIndex = 24;
            this.WhenAnyEarlyBailoutInstruction.Text = "** EDIT Track 01 MD5 file to break validation.";
            // 
            // WhenAnyEarlyBailoutConsole
            // 
            this.WhenAnyEarlyBailoutConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WhenAnyEarlyBailoutConsole.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhenAnyEarlyBailoutConsole.Location = new System.Drawing.Point(5, 5);
            this.WhenAnyEarlyBailoutConsole.Multiline = true;
            this.WhenAnyEarlyBailoutConsole.Name = "WhenAnyEarlyBailoutConsole";
            this.WhenAnyEarlyBailoutConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WhenAnyEarlyBailoutConsole.Size = new System.Drawing.Size(500, 115);
            this.WhenAnyEarlyBailoutConsole.TabIndex = 23;
            // 
            // WhenAnyEarlyBailout
            // 
            this.WhenAnyEarlyBailout.Location = new System.Drawing.Point(10, 125);
            this.WhenAnyEarlyBailout.Name = "WhenAnyEarlyBailout";
            this.WhenAnyEarlyBailout.Size = new System.Drawing.Size(160, 30);
            this.WhenAnyEarlyBailout.TabIndex = 22;
            this.WhenAnyEarlyBailout.Text = "WhenAny - Bailout";
            this.WhenAnyEarlyBailout.UseVisualStyleBackColor = true;
            this.WhenAnyEarlyBailout.Click += new System.EventHandler(this.WhenAnyEarlyBailout_Click);
            // 
            // AsyncPatternsAndPractices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 616);
            this.Controls.Add(this.ConfLogo);
            this.Controls.Add(this.ConferenceTitle);
            this.Controls.Add(this.AllTabs);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.WindowsMediaPlayerControl);
            this.Controls.Add(this.NowPlayingArtwork);
            this.Controls.Add(this.NowPlayingLabel);
            this.Name = "AsyncPatternsAndPractices";
            this.Text = "Async Patterns and Practices";
            ((System.ComponentModel.ISupportInitialize)(this.ConfLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowPlayingArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divider)).EndInit();
            this.AllTabs.ResumeLayout(false);
            this.TabConfiguration.ResumeLayout(false);
            this.TabConfiguration.PerformLayout();
            this.TabWhenAll.ResumeLayout(false);
            this.TabWhenAnyThrottled.ResumeLayout(false);
            this.TabWhenAnyThrottled.PerformLayout();
            this.TabWhenAnyFirst.ResumeLayout(false);
            this.TabWhenAnyFirst.PerformLayout();
            this.TabWhenAnyInterleaved.ResumeLayout(false);
            this.TabWhenAnyInterleaved.PerformLayout();
            this.TabWhenAnyEarlyBailout.ResumeLayout(false);
            this.TabWhenAnyEarlyBailout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ConfLogo;
        private System.Windows.Forms.Label NowPlayingLabel;
        private System.Windows.Forms.PictureBox NowPlayingArtwork;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayerControl;
        private System.Windows.Forms.Label ConferenceTitle;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Label TrackName;
        private System.Windows.Forms.PictureBox Divider;
        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage TabConfiguration;
        private System.Windows.Forms.TabPage TabWhenAll;
        private System.Windows.Forms.TabPage TabWhenAnyFirst;
        private System.Windows.Forms.Button WhenAnyFirstWins;
        private System.Windows.Forms.ProgressBar ProgressBar4;
        private System.Windows.Forms.ProgressBar ProgressBar3;
        private System.Windows.Forms.ProgressBar ProgressBar2;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label ProgressDetails4;
        private System.Windows.Forms.Label ProgressDetails3;
        private System.Windows.Forms.Label ProgressDetails2;
        private System.Windows.Forms.Label ProgressDetails1;
        private System.Windows.Forms.TabPage TabWhenAnyThrottled;
        private System.Windows.Forms.TabPage TabWhenAnyInterleaved;
        private System.Windows.Forms.TabPage TabWhenAnyEarlyBailout;
        private System.Windows.Forms.Button WhenAnyThrottled;
        private System.Windows.Forms.ProgressBar ThrottledProgressBar4;
        private System.Windows.Forms.ProgressBar ThrottledProgressBar3;
        private System.Windows.Forms.ProgressBar ThrottledProgressBar2;
        private System.Windows.Forms.ProgressBar ThrottledProgressBar1;
        private System.Windows.Forms.Label ThrottledFilename4;
        private System.Windows.Forms.Label ThrottledFilename3;
        private System.Windows.Forms.Label ThrottledFilename2;
        private System.Windows.Forms.Label ThrottledFilename1;
        private System.Windows.Forms.Button AudioTempFolderPicker;
        private System.Windows.Forms.Button AudioSourceFolderPicker;
        private System.Windows.Forms.TextBox AudioSourceFolder;
        private System.Windows.Forms.TextBox AudioTempFolder;
        private System.Windows.Forms.Label AudioTemporaryFolderLabel;
        private System.Windows.Forms.Label AudioSourceFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label WhenAllDescription;
        private System.Windows.Forms.Button WhenAll;
        private System.Windows.Forms.Label WhenAnyFirstTip;
        private System.Windows.Forms.Label WhenAnyThrottledTip;
        private System.Windows.Forms.Button WhenAnyInterleaved;
        private System.Windows.Forms.TextBox WhenAnyInterleavedConsole;
        private System.Windows.Forms.Label WhenAnyEarlyBailoutInstruction;
        private System.Windows.Forms.TextBox WhenAnyEarlyBailoutConsole;
        private System.Windows.Forms.Button WhenAnyEarlyBailout;
    }
}

