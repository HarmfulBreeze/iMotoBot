namespace iMotoBot
{
    partial class SongRequest
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
            this.components = new System.ComponentModel.Container();
            this.currentPlaylist = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoPlayer = new Awesomium.Windows.Forms.WebControl(this.components);
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popoutPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banBlacklistSkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatetimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPlaylist
            // 
            this.currentPlaylist.BackColor = System.Drawing.Color.Gray;
            this.currentPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPlaylist.ContextMenuStrip = this.contextMenuStrip;
            this.currentPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentPlaylist.FormattingEnabled = true;
            this.currentPlaylist.Location = new System.Drawing.Point(441, 24);
            this.currentPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentPlaylist.Name = "currentPlaylist";
            this.currentPlaylist.Size = new System.Drawing.Size(174, 262);
            this.currentPlaylist.TabIndex = 1;
            this.currentPlaylist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.currentPlaylist_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Location = new System.Drawing.Point(10, 35);
            this.videoPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoPlayer.Size = new System.Drawing.Size(420, 241);
            this.videoPlayer.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.videoPlayer.TabIndex = 2;
            this.videoPlayer.LoadingFrameComplete += new Awesomium.Core.FrameEventHandler(this.Awesomium_Windows_Forms_WebControl_LoadingFrameComplete);
            // 
            // songTimer
            // 
            this.songTimer.Interval = 1000;
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.popoutPlayerToolStripMenuItem,
            this.songOptionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(615, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.enabledToolStripMenuItem.Text = "&Enable";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // popoutPlayerToolStripMenuItem
            // 
            this.popoutPlayerToolStripMenuItem.Name = "popoutPlayerToolStripMenuItem";
            this.popoutPlayerToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.popoutPlayerToolStripMenuItem.Text = "Popout Player";
            this.popoutPlayerToolStripMenuItem.Click += new System.EventHandler(this.popoutPlayerToolStripMenuItem_Click);
            // 
            // songOptionsToolStripMenuItem
            // 
            this.songOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banBlacklistSkipToolStripMenuItem,
            this.skipBlacklistToolStripMenuItem,
            this.skipToolStripMenuItem});
            this.songOptionsToolStripMenuItem.Name = "songOptionsToolStripMenuItem";
            this.songOptionsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.songOptionsToolStripMenuItem.Text = "Song Options";
            // 
            // banBlacklistSkipToolStripMenuItem
            // 
            this.banBlacklistSkipToolStripMenuItem.Name = "banBlacklistSkipToolStripMenuItem";
            this.banBlacklistSkipToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.banBlacklistSkipToolStripMenuItem.Text = "Ban -> Blacklist -> Skip";
            this.banBlacklistSkipToolStripMenuItem.Click += new System.EventHandler(this.banBlacklistSkipToolStripMenuItem_Click);
            // 
            // skipBlacklistToolStripMenuItem
            // 
            this.skipBlacklistToolStripMenuItem.Name = "skipBlacklistToolStripMenuItem";
            this.skipBlacklistToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.skipBlacklistToolStripMenuItem.Text = "Blacklist -> Skip";
            this.skipBlacklistToolStripMenuItem.Click += new System.EventHandler(this.skipBlacklistToolStripMenuItem_Click);
            // 
            // skipToolStripMenuItem
            // 
            this.skipToolStripMenuItem.Name = "skipToolStripMenuItem";
            this.skipToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.skipToolStripMenuItem.Text = "Skip";
            this.skipToolStripMenuItem.Click += new System.EventHandler(this.skipToolStripMenuItem_Click);
            // 
            // updatetimer
            // 
            this.updatetimer.Enabled = true;
            this.updatetimer.Interval = 5000;
            this.updatetimer.Tick += new System.EventHandler(this.updatetimer_Tick);
            // 
            // SongRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 286);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.currentPlaylist);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SongRequest";
            this.Text = "Song Request - iMotoBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongRequest_FormClosing);
            this.Load += new System.EventHandler(this.SongRequest_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox currentPlaylist;
        private Awesomium.Windows.Forms.WebControl videoPlayer;
        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.Timer songTimer;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popoutPlayerToolStripMenuItem;
        private System.Windows.Forms.Timer updatetimer;
        private System.Windows.Forms.ToolStripMenuItem songOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipBlacklistToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banBlacklistSkipToolStripMenuItem;
    }
}