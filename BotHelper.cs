using System;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Collections.Generic;

using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace iMotoBot
{
    public class BotHelper
    {
        private int port;
        private string nick, oauth, server, channel;
        private string buf;

        private bool joinedChannel;

        private TcpClient socket;

        private TextReader input;
        private TextWriter output;

        /// <summary>
        /// Song Request
        /// </summary>
        public List<VideoMeta>  playlist;
        public List<string>     blacklist;

        public bool             banBlacklist;   // ban on blacklist requests;
        public bool             songRequest;
        public VideoMeta        currentVideo;

        public BotHelper(string channel, string oauth)
        {
            socket = new TcpClient();

            nick = "iMotoBot";
            server = "irc.twitch.tv";
            port = 6667;
            this.channel = "#" + channel.ToLower();
            this.oauth = oauth;

            joinedChannel = false;

            playlist = new List<VideoMeta>();
            blacklist = new List<string>();

            banBlacklist = false;
            songRequest = true;
            currentVideo = null;
        }

        public void Connect()
        {
            socket.Connect(server, port);

            input = new StreamReader(socket.GetStream());
            output = new StreamWriter(socket.GetStream());

            output.Write(
                "PASS " + oauth + "\r\n" +
                "NICK " + nick + "\r\n"
            );
            output.Flush();

            JoinChannel();
        }

        public void Disconnect()
        {
            PartChannel();
            socket.Close();
        }

        public void Run()
        {
            string[]    data;
            char[]      charSeparator = new char[] { ' ' };

            while (socket.Connected)
            {
                try
                {
                    buf = input.ReadLine();
                    Debug.Print(buf);
                }
                catch (IOException) { }

                data = buf.Split(charSeparator, 5);

                if (!joinedChannel)
                {
                    if (data[1] == "MODE")
                        joinedChannel = true;
                }

                // send pong reply to ping messages
                if (buf.StartsWith("PING "))
                {
                    output.Write(buf.Replace("PING", "PONG") + "\r\n");
                    output.Flush();
                }

                if (data.Length >= 4)
                {
                    string command = data[3];

                    if (command == ":!songrequest")
                    {
                        try
                        {
                            RequestSong(data[0], data[4]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                    }

                    if (command == ":!currentsong")
                    {
                        if (currentVideo != null)
                        {
                            SendMessage(currentVideo.name + " - Requested by: " + currentVideo.requester);
                        }
                    }

                    if (command == ":!Nesszors")
                    {
                        SendMessage("Ness is shit.");
                    }
                }
            }
        }

        private void SendMessage(string message)
        {
            output.Write("PRIVMSG " + channel + " :" + message + "\r\n");
            output.Flush();
        }

        public void BanUser(string username)
        {
            output.Write("PRIVMSG " + channel + " :.ban " + username + "\r\n");
            output.Flush();
        }

        private void JoinChannel()
        {
            output.Write("JOIN " + channel + "\r\n");
            output.Flush();
        }

        private void PartChannel()
        {
            output.Write("PART " + channel + "\r\n");
            output.Flush();

            joinedChannel = false;
        }

        /// <summary>
        /// Request the damn song. Parse data
        /// </summary>
        /// <param name="username"></param>
        /// <param name="data"></param>
        private void RequestSong(string username, string data)
        {
            if (songRequest)
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;

                try
                {
                    VideoMeta video = new VideoMeta();

                    string source;
                    string[] delimeter;
                    string[] metaData;
                    string vMeta;

                    if (data.Contains("youtu.be"))
                    {
                        source = wc.DownloadString(data);
                        vMeta = data.Substring(data.Length - 11);
                    }
                    else if (data.Length > 11) // 11 is the char limit for ?v
                    {
                        source = wc.DownloadString(data);
                        delimeter = new string[] { "v=" };
                        metaData = data.Split(delimeter, StringSplitOptions.None);
                        vMeta = metaData[1].Substring(0, 11);
                    }
                    else
                    {
                        vMeta = data;
                        source = wc.DownloadString("https://youtu.be/" + vMeta);
                    }

                    bool blacklistedVideoRequested = false;

                    foreach (string blVideo in blacklist)
                    {
                        if (blVideo == vMeta)
                        {
                            blacklistedVideoRequested = true;
                        }
                    }

                    if (!blacklistedVideoRequested)
                    {
                        string metaTitle = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;

                        Debug.Print(metaTitle);

                        string title = metaTitle.Substring(0, metaTitle.Length - 9);

                        delimeter = new string[] { "<meta itemprop=\"duration\" content=\"PT" };
                        metaData = source.Split(delimeter, StringSplitOptions.None);
                        delimeter = new string[] { "\">" };
                        metaData = metaData[1].Split(delimeter, StringSplitOptions.None);
                        delimeter = new string[] { "M", "S" };
                        metaData = metaData[0].Split(delimeter, StringSplitOptions.None);

                        video.requester = username.Substring(1, username.IndexOf("!") - 1);
                        video.name = title;
                        video.v = vMeta;
                        video.duration = ((Int32.Parse(metaData[0]) * 60) * 1000) + (Int32.Parse(metaData[1]) * 1000);

                        SendMessage(video.name + "has been added to queue.");

                        playlist.Add(video);
                    }
                    else
                    {
                        //SendMessage("THIS VIDEO IS BLACKLISTED."); // can remove this if you dont want to show a message

                        if (banBlacklist)
                        {
                            video.requester = username.Substring(1, username.IndexOf("!") - 1);
                            BanUser(video.requester);
                        }
                    }
                }
                catch (System.Net.WebException)
                {
                    SendMessage("Sorry, that video does not exist.");
                }
            }
        }
    }
}
