namespace iMotoBot
{
    partial class ConfigurationWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDonations = new System.Windows.Forms.CheckBox();
            this.chkHosts = new System.Windows.Forms.CheckBox();
            this.chkSubscribers = new System.Windows.Forms.CheckBox();
            this.chkFollowers = new System.Windows.Forms.CheckBox();
            this.btnSaveConfiguration = new System.Windows.Forms.Button();
            this.chkRunAtStart = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkIRCGetOAuth = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIRCOAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIRCChannel = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTwitchOAuth = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTAAccessToken = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSaveConfiguration);
            this.tabPage1.Controls.Add(this.chkRunAtStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDonations);
            this.groupBox1.Controls.Add(this.chkHosts);
            this.groupBox1.Controls.Add(this.chkSubscribers);
            this.groupBox1.Controls.Add(this.chkFollowers);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Display Data";
            // 
            // chkDonations
            // 
            this.chkDonations.AutoSize = true;
            this.chkDonations.Location = new System.Drawing.Point(32, 90);
            this.chkDonations.Name = "chkDonations";
            this.chkDonations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDonations.Size = new System.Drawing.Size(91, 22);
            this.chkDonations.TabIndex = 3;
            this.chkDonations.Text = ":Donations";
            this.chkDonations.UseVisualStyleBackColor = true;
            // 
            // chkHosts
            // 
            this.chkHosts.AutoSize = true;
            this.chkHosts.Location = new System.Drawing.Point(60, 68);
            this.chkHosts.Name = "chkHosts";
            this.chkHosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHosts.Size = new System.Drawing.Size(63, 22);
            this.chkHosts.TabIndex = 2;
            this.chkHosts.Text = ":Hosts";
            this.chkHosts.UseVisualStyleBackColor = true;
            // 
            // chkSubscribers
            // 
            this.chkSubscribers.AutoSize = true;
            this.chkSubscribers.Location = new System.Drawing.Point(25, 45);
            this.chkSubscribers.Name = "chkSubscribers";
            this.chkSubscribers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSubscribers.Size = new System.Drawing.Size(98, 22);
            this.chkSubscribers.TabIndex = 1;
            this.chkSubscribers.Text = ":Subscribers";
            this.chkSubscribers.UseVisualStyleBackColor = true;
            // 
            // chkFollowers
            // 
            this.chkFollowers.AutoSize = true;
            this.chkFollowers.Location = new System.Drawing.Point(35, 22);
            this.chkFollowers.Name = "chkFollowers";
            this.chkFollowers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFollowers.Size = new System.Drawing.Size(88, 22);
            this.chkFollowers.TabIndex = 0;
            this.chkFollowers.Text = ":Followers";
            this.chkFollowers.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.Location = new System.Drawing.Point(335, 276);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(133, 28);
            this.btnSaveConfiguration.TabIndex = 1;
            this.btnSaveConfiguration.Text = "Save Configuration";
            this.btnSaveConfiguration.UseVisualStyleBackColor = true;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // chkRunAtStart
            // 
            this.chkRunAtStart.AutoSize = true;
            this.chkRunAtStart.Location = new System.Drawing.Point(8, 282);
            this.chkRunAtStart.Name = "chkRunAtStart";
            this.chkRunAtStart.Size = new System.Drawing.Size(99, 22);
            this.chkRunAtStart.TabIndex = 0;
            this.chkRunAtStart.Text = "Run At Start";
            this.chkRunAtStart.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OAuth";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(470, 307);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.linkIRCGetOAuth);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txtIRCOAuth);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.txtIRCChannel);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(462, 276);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "IRC";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // linkIRCGetOAuth
            // 
            this.linkIRCGetOAuth.AutoSize = true;
            this.linkIRCGetOAuth.Location = new System.Drawing.Point(356, 87);
            this.linkIRCGetOAuth.Name = "linkIRCGetOAuth";
            this.linkIRCGetOAuth.Size = new System.Drawing.Size(102, 18);
            this.linkIRCGetOAuth.TabIndex = 4;
            this.linkIRCGetOAuth.TabStop = true;
            this.linkIRCGetOAuth.Text = "Get New OAuth";
            this.linkIRCGetOAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIRCGetOAuth_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "IRC OAuth";
            // 
            // txtIRCOAuth
            // 
            this.txtIRCOAuth.Location = new System.Drawing.Point(9, 82);
            this.txtIRCOAuth.Name = "txtIRCOAuth";
            this.txtIRCOAuth.PasswordChar = '●';
            this.txtIRCOAuth.Size = new System.Drawing.Size(341, 22);
            this.txtIRCOAuth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel";
            // 
            // txtIRCChannel
            // 
            this.txtIRCChannel.Location = new System.Drawing.Point(9, 33);
            this.txtIRCChannel.Name = "txtIRCChannel";
            this.txtIRCChannel.Size = new System.Drawing.Size(341, 22);
            this.txtIRCChannel.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.txtTwitchOAuth);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(462, 276);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Twitch";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subscriber OAuth";
            // 
            // txtTwitchOAuth
            // 
            this.txtTwitchOAuth.Location = new System.Drawing.Point(9, 33);
            this.txtTwitchOAuth.Name = "txtTwitchOAuth";
            this.txtTwitchOAuth.PasswordChar = '●';
            this.txtTwitchOAuth.Size = new System.Drawing.Size(341, 22);
            this.txtTwitchOAuth.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtTAAccessToken);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(476, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Donations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Access Token";
            // 
            // txtTAAccessToken
            // 
            this.txtTAAccessToken.Location = new System.Drawing.Point(11, 30);
            this.txtTAAccessToken.Name = "txtTAAccessToken";
            this.txtTAAccessToken.Size = new System.Drawing.Size(341, 22);
            this.txtTAAccessToken.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(476, 313);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Alert Profiles";
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(476, 313);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Song Request";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // ConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 347);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationWindow";
            this.Text = "Configuration - iMotoBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigurationWindow_FormClosing);
            this.Load += new System.EventHandler(this.ConfigurationWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveConfiguration;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.LinkLabel linkIRCGetOAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage7;
        internal System.Windows.Forms.CheckBox chkDonations;
        internal System.Windows.Forms.CheckBox chkHosts;
        internal System.Windows.Forms.CheckBox chkSubscribers;
        internal System.Windows.Forms.CheckBox chkFollowers;
        internal System.Windows.Forms.CheckBox chkRunAtStart;
        internal System.Windows.Forms.TextBox txtIRCOAuth;
        internal System.Windows.Forms.TextBox txtIRCChannel;
        internal System.Windows.Forms.TextBox txtTwitchOAuth;
        internal System.Windows.Forms.TextBox txtTAAccessToken;
    }
}