namespace VLCLIB
{
    partial class VlcTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startVid = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            nxtFrame = new Button();
            snapshotBtn = new Button();
            pauseBtn = new Button();
            playPause = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            openFileDialog1 = new OpenFileDialog();
            SelectVid = new Button();
            FitScreen = new Button();
            videoPath = new Label();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // startVid
            // 
            startVid.Location = new Point(3, 411);
            startVid.Name = "startVid";
            startVid.Size = new Size(50, 26);
            startVid.TabIndex = 1;
            startVid.Text = "Start";
            startVid.UseVisualStyleBackColor = true;
            startVid.Click += startVid_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(3, 12);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(785, 320);
            videoView1.TabIndex = 4;
            videoView1.Text = "videoView1";
            videoView1.Click += videoView1_Click;
            // 
            // nxtFrame
            // 
            nxtFrame.Location = new Point(119, 411);
            nxtFrame.Name = "nxtFrame";
            nxtFrame.Size = new Size(49, 27);
            nxtFrame.TabIndex = 5;
            nxtFrame.Text = "Next Frame";
            nxtFrame.UseVisualStyleBackColor = true;
            nxtFrame.Click += nxtFrame_Click;
            // 
            // snapshotBtn
            // 
            snapshotBtn.Location = new Point(194, 411);
            snapshotBtn.Name = "snapshotBtn";
            snapshotBtn.Size = new Size(70, 27);
            snapshotBtn.TabIndex = 6;
            snapshotBtn.Text = "Snapshot";
            snapshotBtn.UseVisualStyleBackColor = true;
            snapshotBtn.Click += snapshotBtn_Click;
            // 
            // pauseBtn
            // 
            pauseBtn.Location = new Point(59, 411);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(54, 27);
            pauseBtn.TabIndex = 2;
            pauseBtn.Text = "Stop";
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // playPause
            // 
            playPause.Location = new Point(315, 410);
            playPause.Name = "playPause";
            playPause.Size = new Size(78, 27);
            playPause.TabIndex = 7;
            playPause.Text = "Play/Pause";
            playPause.UseVisualStyleBackColor = true;
            playPause.Click += playPause_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 363);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Current Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 368);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 10;
            label2.Text = "Total";
            label2.Click += label2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 338);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(785, 45);
            trackBar1.TabIndex = 11;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "video";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // SelectVid
            // 
            SelectVid.Location = new Point(585, 410);
            SelectVid.Name = "SelectVid";
            SelectVid.Size = new Size(91, 23);
            SelectVid.TabIndex = 13;
            SelectVid.Text = "Select Video";
            SelectVid.UseVisualStyleBackColor = true;
            SelectVid.Click += SelectVid_Click;
            // 
            // FitScreen
            // 
            FitScreen.Location = new Point(682, 410);
            FitScreen.Name = "FitScreen";
            FitScreen.Size = new Size(91, 23);
            FitScreen.TabIndex = 14;
            FitScreen.Text = "Fit Screen";
            FitScreen.UseVisualStyleBackColor = true;
            FitScreen.Click += button1_Click;
            // 
            // videoPath
            // 
            videoPath.AutoSize = true;
            videoPath.Location = new Point(315, 368);
            videoPath.Name = "videoPath";
            videoPath.Size = new Size(78, 15);
            videoPath.TabIndex = 15;
            videoPath.Text = "Path to Video";
            videoPath.Click += videoPath_Click;
            // 
            // VlcTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(videoPath);
            Controls.Add(FitScreen);
            Controls.Add(pauseBtn);
            Controls.Add(startVid);
            Controls.Add(SelectVid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(playPause);
            Controls.Add(snapshotBtn);
            Controls.Add(nxtFrame);
            Controls.Add(videoView1);
            Name = "VlcTest";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startVid;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private Button nxtFrame;
        private Button snapshotBtn;
        private Button pauseBtn;
        private Button playPause;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private OpenFileDialog openFileDialog1;
        private Button SelectVid;
        private Button FitScreen;
        private Label videoPath;
    }
}
