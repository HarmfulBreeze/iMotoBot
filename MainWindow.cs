using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using System.Diagnostics;

namespace iMotoBot
{
    public partial class MainWindow : Form
    {
        public YoutubePlayer            youtubePlayer;
        public SongRequest              songRequest;
        public ConfigurationWindow      configWindow;

        public  BotHelper               BotHelper;
        private Thread                  BotHelperThread;

        public bool isRunning;

        public MainWindow()
        {
            InitializeComponent();
            songRequest = new SongRequest(this);
            youtubePlayer = new YoutubePlayer(this);
            configWindow = new ConfigurationWindow(this);

            BotHelper = new BotHelper(configWindow.txtIRCChannel.Text, configWindow.txtIRCOAuth.Text);
            BotHelperThread = new Thread(new ThreadStart(BotHelper.Run));

            isRunning = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string blFile = @"blacklist.dat";

            if (!File.Exists(blFile))
            {
                StreamWriter sw = new StreamWriter(blFile);
                sw.Close();
            }

            populateBlacklist();
        }

        private void populateBlacklist()
        {
            string blFile = @"blacklist.dat";

            if (File.Exists(blFile))
            {
                StreamReader sr = new StreamReader(blFile);
                try
                {
                    do
                    {
                        string video = sr.ReadLine();
                        BotHelper.blacklist.Add(video);
                    } 
                    while (sr.Peek() != -1);
                }
                catch
                {
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                startToolStripMenuItem.Text = "&Stop";

                BotHelper.Connect();

                if (!BotHelperThread.IsAlive)
                    BotHelperThread.Start();
            }
            else
            {
                startToolStripMenuItem.Text = "&Start";
                BotHelper.Disconnect();
            }
        }

        private void songRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songRequestToolStripMenuItem.Checked = !songRequestToolStripMenuItem.Checked;
            songRequest.Visible = songRequestToolStripMenuItem.Checked;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isRunning)
                BotHelper.Disconnect();
        }

        private void configurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            configWindow.Visible = !configWindow.Visible;
        }    
    }
}
