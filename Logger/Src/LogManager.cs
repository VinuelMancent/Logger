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
        
        private IList<IChannel> channels = new List<IChannel>(); //stores all created channels
        
        //private Constructor for Singleton pattern
        //Adds default Console Output channel
        private LogManager()
        {
            channels.Add(new ChannelConsole());
        }

        #nullable enable
        //Add a new channel to the logging instance
        public void AddChannel(IChannel channel)
        {
            bool channelAlreadyExists = false;
            foreach (var chan in channels)
            {
                if (chan.GetName() == channel.GetName())
                {
                    channelAlreadyExists = true;
                }
            }
            if(channelAlreadyExists)
            {
                Info("Console", $"Channel with the name {channel.GetName()} already exists, please choose another name");
                return;
            }
            channels.Add(channel);
        }

        public void Debug3(string channel, string message)
        {
            getChannelByName(channel).Debug3(message);
        }

        public void Debug2(string channel, string message)
        {
            getChannelByName(channel).Debug2(message);
        }

        public void Debug1(string channel, string message)
        {
            getChannelByName(channel).Debug1(message);   
        }
        public void Info(string channel, string message)
        {
            getChannelByName(channel).Info(message);
        }

        private IChannel getChannelByName(string channelName)
        {
            foreach (var chan in channels)
            {
                if (chan.GetName() == channelName)
                {
                    return chan;
                }
            }
            throw new ChannelNotFoundException($"Could not find channel {channelName}");
        }
    }
}