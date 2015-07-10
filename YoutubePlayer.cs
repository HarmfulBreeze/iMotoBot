using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMotoBot
{
    public partial class YoutubePlayer : Form
    {
        private MainWindow parent;

        public YoutubePlayer(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(object sender, Awesomium.Core.FrameEventArgs e)
        {
            parent.songRequest.songTimer.Start();
        }
    }
}
