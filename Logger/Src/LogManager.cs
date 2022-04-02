using System;
using System.Collections.Generic;

namespace Logger
{
    public class LogManager
    {
        private static readonly Lazy<LogManager> Lazy = new Lazy<LogManager>(() => new LogManager() );
        
        public static LogManager Instance
        {
            get
            {
                return Lazy.Value;
            }
        }
        
        private Dictionary<string, IChannel> channels = new Dictionary<string, IChannel>(); //stores all created channels
        
        //private Constructor for Singleton pattern
        //Adds default Console Output channel
        private LogManager()
        {
            channels.Add("default", new ChannelConsole());
        }

        #nullable enable
        //Add a new channel to the logging instance
        public void AddChannel(string channelName, IChannel channel)
        {
            if (!channels.ContainsKey(channelName))
            {
                this.channels.Add(channelName, channel);
            }
            else
            {
                Info("default", $"Channel with the name {channelName} already exists, please choose another name");
            }
        }

        public void Debug3(string channel, string message)
        {
            if (channels.ContainsKey(channel))
                channels[channel].Debug3(message);
        }

        public void Debug2(string channel, string message)
        {
            if (channels.ContainsKey(channel))
                channels[channel].Debug2(message);
        }

        public void Debug1(string channel, string message)
        {
            if (channels.ContainsKey(channel))
                channels[channel].Debug1(message);   
        }
        public void Info(string channel, string message)
        {
            if (channels.ContainsKey(channel))
                channels[channel].Info(message);
        }
    }
}