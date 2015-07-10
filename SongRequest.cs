using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace iMotoBot
{
    public partial class SongRequest : Form
    {
        private MainWindow parent;

        public SongRequest(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;

            currentPlaylist.DisplayMember = "name";
        }

        private void SongRequest_Load(object sender, EventArgs e)
        {
            videoPlayer.Source = new Uri("about:blank");

            enabledToolStripMenuItem.Checked = parent.BotHelper.songRequest;
            songTimer.Enabled = true;

            if (!enabledToolStripMenuItem.Checked)
            {
                enabledToolStripMenuItem.Text = "&Enable";
            }
            else
            {
                enabledToolStripMenuItem.Text = "&Disable";
            }
        }

        private void Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(object sender, Awesomium.Core.FrameEventArgs e)
        {
            songTimer.Start();
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            updateCurrentSong();
        }

        private void SongRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.songRequestToolStripMenuItem.Checked = false;

            this.Hide();
            e.Cancel = true;
        }

        private void popoutPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popoutPlayerToolStripMenuItem.Checked = !popoutPlayerToolStripMenuItem.Checked;

            if (popoutPlayerToolStripMenuItem.Checked)
            {
                parent.youtubePlayer.Show();
                videoPlayer.Visible = false;

                parent.youtubePlayer.videoPlayer.Source = videoPlayer.Source;
                videoPlayer.Source = new Uri("about:blank");

                popoutPlayerToolStripMenuItem.Text = "Show Player";
                currentPlaylist.Dock = DockStyle.Fill;

                this.Width = 280;
            }
            else
            {
                parent.youtubePlayer.Hide();
                videoPlayer.Visible = true;

                videoPlayer.Source = parent.youtubePlayer.videoPlayer.Source;
                parent.youtubePlayer.videoPlayer.Source = new Uri("about:blank");

                popoutPlayerToolStripMenuItem.Text = "Popout Player";
                currentPlaylist.Dock = DockStyle.Right;

                this.Width = 832;
            }
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.BotHelper.songRequest = !parent.BotHelper.songRequest;
            enabledToolStripMenuItem.Checked = parent.BotHelper.songRequest;

            if (!enabledToolStripMenuItem.Checked)
            {
                enabledToolStripMenuItem.Text = "&Enable";
            }
            else
            {
                enabledToolStripMenuItem.Text = "&Disable";
            }
        }

        private void updatetimer_Tick(object sender, EventArgs e)
        {
            updatePlaylist();
        }

        private void currentPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = currentPlaylist.PointToScreen(e.Location);
                contextMenuStrip.Show(pt);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentPlaylist.Items.Count > 0)
            {
                parent.BotHelper.playlist.RemoveAt(currentPlaylist.SelectedIndex);
                updatePlaylist();
            }
        }

        private void skipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCurrentSong();
        }

        private void skipBlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (parent.BotHelper.currentVideo != null)
            {
                parent.BotHelper.blacklist.Add(parent.BotHelper.currentVideo.name);
                File.AppendAllText(@"blacklist.dat", parent.BotHelper.currentVideo + Environment.NewLine);
                updateCurrentSong();
            }
        }

        private void banBlacklistSkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (parent.BotHelper.currentVideo != null)
            {
                parent.BotHelper.BanUser(parent.BotHelper.currentVideo.requester);
                parent.BotHelper.blacklist.Add(parent.BotHelper.currentVideo.name);
                File.AppendAllText(@"blacklist.dat", parent.BotHelper.currentVideo + Environment.NewLine);
                updateCurrentSong();
            }
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////
        /// </summary>
        private void updatePlaylist()
        {
            if (parent.BotHelper.playlist.Count != currentPlaylist.Items.Count)
            {
                currentPlaylist.Items.Clear();

                foreach (VideoMeta meta in parent.BotHelper.playlist)
                {
                    currentPlaylist.Items.Add(meta);
                }
            }
        }

        private void updateCurrentSong()
        {
            if (parent.isRunning & parent.BotHelper.songRequest)
            {
                if (parent.BotHelper.playlist.Count > 0)
                {

                    parent.BotHelper.currentVideo = parent.BotHelper.playlist[0];

                    if (!popoutPlayerToolStripMenuItem.Checked)
                    {
                        videoPlayer.Source = new Uri(
                            "http://www.youtube.com/embed/"
                            + parent.BotHelper.playlist[0].v // video
                            + "?autoplay=1"
                            + "&iv_load_policy=3"   // hide annotations
                            + "&rel=0"              // dont show related videos
                            + "&fs=0"               // disable fullscreen
                        );
                    }
                    else
                    {
                        parent.youtubePlayer.videoPlayer.Source = new Uri(
                            "http://www.youtube.com/embed/"
                            + parent.BotHelper.playlist[0].v // video
                            + "?autoplay=1"
                            + "&iv_load_policy=3"   // hide annotations
                            + "&rel=0"              // dont show related videos
                            + "&fs=0"               // disable fullscreen
                        );
                    }

                    songTimer.Stop();
                    songTimer.Interval = parent.BotHelper.playlist[0].duration + 1;

                    parent.BotHelper.playlist.RemoveAt(0);
                    updatePlaylist();
                }
                else
                {
                    videoPlayer.Source = new Uri("about:blank");
                    parent.youtubePlayer.videoPlayer.Source = new Uri("about:blank");

                    parent.BotHelper.currentVideo = null;
                    songTimer.Interval = 1000;
                }
            }
        }
    }
}
