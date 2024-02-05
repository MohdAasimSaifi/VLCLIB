using System;
using Vlc.DotNet.Core.Interops.Signatures;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System.Windows.Media;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Controls;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vlc.DotNet.Forms;

namespace VLCLIB
{
    public partial class VlcTest : Form
    {
        private LibVLC libVLC = new LibVLC();
        private LibVLCSharp.Shared.MediaPlayer mediaPlayer;
        private bool isPlaying = false;
        private double frameDurationInSeconds = 1.0 / 25.0;
        private bool isFit = false;
        public VlcTest()
        {
            InitializeComponent();
        }
        string PathToVideo = "C:\\Users\\INTERCEPTOR\\Downloads\\video.mp4";
        private void Form1_Load(object sender, EventArgs e)
        {

            mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libVLC);
            videoPath.Text = PathToVideo;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100; // Update every 100 milliseconds
            timer1.Tick += Timer_Tick;
            timer1.Start();
            videoPath.Dock = DockStyle.Top;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (mediaPlayer.Length > 0)
            {
                try
                {
                    double progress = (double)mediaPlayer.Time / (mediaPlayer.Length + 1);
                    int progressBarValue = (int)(progress * trackBar1.Maximum);
                    trackBar1.Value = progressBarValue;
                    label1.Text = TimeSpan.FromMilliseconds(mediaPlayer.Time).ToString(@"hh\:mm\:ss");
                    label2.Text = TimeSpan.FromMilliseconds(mediaPlayer.Length).ToString(@"hh\:mm\:ss");


                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        private void startVid_Click(object sender, EventArgs e)
        {

            var media = new Media(libVLC, PathToVideo);
            mediaPlayer.Media = media;
            videoView1.MediaPlayer = mediaPlayer;
            //videoView1.Dock = DockStyle.Fill;
            mediaPlayer.Play();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            mediaPlayer.Stop();
        }
        private void nxtFrame_Click(object sender, EventArgs e)
        {

            if (!isPlaying)
            {
                // Jump forward by the duration of a single frame 
                mediaPlayer.Time += (long)(frameDurationInSeconds * 1000); // Time is in milliseconds
            }


        }
        private void CaptureSnapshot()
        {
            // Get the screen coordinates of the videoView1 control
            Point locationOnScreen = videoView1.PointToScreen(Point.Empty);
            Bitmap bitmap = new Bitmap(videoView1.Width, videoView1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Copy the content of the videoView1 control to the bitmap
                graphics.CopyFromScreen(locationOnScreen, Point.Empty, videoView1.Size);
            }
            var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            var snapshotPath = $"C:\\Users\\INTERCEPTOR\\Downloads\\Snapshots";
            var snapshotName = $"\\snapshot_{timestamp}.png";
            var FullSnapshotPath = snapshotPath + snapshotName;
            if (!Directory.Exists(snapshotPath))
            {
                Directory.CreateDirectory(snapshotPath);
                bitmap.Save(FullSnapshotPath, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                bitmap.Save(FullSnapshotPath, System.Drawing.Imaging.ImageFormat.Png);
            }

        }


        private void snapshotBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                CaptureSnapshot();
            });
        }

        private void playPause_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                mediaPlayer.Pause();
                isPlaying = false;
            }
            else
            {
                mediaPlayer.Play();
                isPlaying = true;
            }
        }
        private void SelectVid_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Video";
            openFileDialog1.Filter = "Video file(*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathToVideo = openFileDialog1.FileName;
                videoPath.Text = PathToVideo;
                //for directly play the video
                var media = new Media(libVLC, PathToVideo);
                mediaPlayer.Media = media;
                videoView1.MediaPlayer = mediaPlayer;
                mediaPlayer.Play();
            }

        }
        private void videoView1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isFit)
            {
                videoView1.MediaPlayer.AspectRatio = string.Format("{0}:{1}", videoView1.Width, videoView1.Height);
                isFit = true;
            }
            else
            {
                videoView1.MediaPlayer.AspectRatio = null;
                isFit = false;
            }

        }

        private void videoPath_Click(object sender, EventArgs e)
        {

        }
    }
}
