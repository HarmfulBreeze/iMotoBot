namespace iMotoBot
{
    partial class YoutubePlayer
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
            this.videoPlayer = new Awesomium.Windows.Forms.WebControl(this.components);
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer.Size = new System.Drawing.Size(564, 319);
            this.videoPlayer.TabIndex = 4;
            this.videoPlayer.LoadingFrameComplete += new Awesomium.Core.FrameEventHandler(this.Awesomium_Windows_Forms_WebControl_LoadingFrameComplete);
            // 
            // YoutubePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(564, 319);
            this.ControlBox = false;
            this.Controls.Add(this.videoPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YoutubePlayer";
            this.Text = "Youtube Player - iMotoBot";
            this.ResumeLayout(false);

        }

        #endregion

        public Awesomium.Windows.Forms.WebControl videoPlayer;



    }
}