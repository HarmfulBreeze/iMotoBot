using System;
using System.IO;
using System.Windows.Forms;

using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace iMotoBot
{
    public partial class ConfigurationWindow : Form
    {
        private MainWindow parent;

        private string configFilePath;

        private bool initialized;
        public ConfigurationWindow(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;

            configFilePath = @"settings.cfg";

            initialized = false;

            LoadConfiguration();
        }

        private void ConfigurationWindow_Load(object sender, EventArgs e)
        {
            LinkLabel.Link ircOAuthLink = new LinkLabel.Link();

            ircOAuthLink.LinkData = "http://twitchapps.com/tmi";
            linkIRCGetOAuth.Links.Add(ircOAuthLink);
        }

        private void linkIRCGetOAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void ConfigurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.configurationToolStripMenuItem.Checked = false;

            this.Hide();
            e.Cancel = true;
        }

        public void LoadConfiguration()
        {
            try
            {
                using (StreamReader file = new StreamReader(configFilePath))
                {
                    string data = file.ReadToEnd();

                    string guid = data.Remove(36, data.Length - 36);
                    string json = Encryption.Decrypt(data.Remove(0, 36), guid);

                    JToken token = JObject.Parse(json);

                    chkFollowers.Checked = (bool)token["general_config"]["play_followers"];
                    chkSubscribers.Checked = (bool)token["general_config"]["play_subscribers"];
                    chkDonations.Checked = (bool)token["general_config"]["play_donations"];
                    chkHosts.Checked = (bool)token["general_config"]["play_hosts"];
                    chkRunAtStart.Checked = (bool)token["general_config"]["run_at_start"];

                    txtIRCChannel.Text = (string)token["twitch_config"]["channel_name"];
                    txtIRCOAuth.Text = (string)token["twitch_config"]["irc_oauth"];
                    txtTwitchOAuth.Text = (string)token["twitch_config"]["subscriber_oauth"];

                    txtTAAccessToken.Text = (string)token["twitch_alert_config"]["ta_access_token"];
                }

                initialized = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(null, "Configuration file not found - creating blank configuration file.", "Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                chkFollowers.Checked = true;
                chkSubscribers.Checked = true;
                chkDonations.Checked = true;
                chkHosts.Checked = true;

                initialized = true;

                SaveConfiguration();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(null, "Please either fix or delete the current configuration file to continue loading the program." +
                                " The program will now terminate",
                                "Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private JObject generateTwitchConfig()
        {
            JObject config = JObject.FromObject(new
            {
                twitch_config = new
                {
                    channel_name = txtIRCChannel.Text,
                    irc_oauth = txtIRCOAuth.Text,
                    subscriber_oauth = txtTwitchOAuth.Text
                }
            });

            return config;
        }

        private JObject generateTwitchAlertConfig()
        {
            JObject config = JObject.FromObject(new
            {
                twitch_alert_config = new
                {
                    ta_access_token = txtTAAccessToken.Text
                }
            });

            return config;
        }

        private JObject generateGeneralConfig()
        {
            JObject config = JObject.FromObject(new
            {
                general_config = new
                {
                    play_followers = chkFollowers.Checked,
                    play_subscribers = chkSubscribers.Checked,
                    play_donations = chkDonations.Checked,
                    play_hosts = chkHosts.Checked,
                    run_at_start = chkRunAtStart.Checked
                }
            });

            return config;
        }


        private void SaveConfiguration()
        {
            JObject config = new JObject();

            config.Merge(generateGeneralConfig());
            config.Merge(generateTwitchConfig());
            config.Merge(generateTwitchAlertConfig());

            using (StreamWriter file = new StreamWriter(configFilePath))
            {
                string guid = Guid.NewGuid().ToString();
                string data = guid + Encryption.Encrypt(config.ToString(), guid);

                file.WriteLine(data);
                MessageBox.Show(null, "Configuration file has been saved successfully.", "Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
        }
    }
}
