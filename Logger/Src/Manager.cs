using System;
using System.Collections.Generic;

namespace Logger.Src
{
    public class Manager
    {
        private static readonly Lazy<Manager> lazy = new Lazy<Manager>(() => new Manager() );
        
        public static Manager Instance
        {
            get { return lazy.Value; }
        }
        
        private Dictionary<string, Logger> Channels; //stores all created channels
        
        //creates the default logger, logging everything into console
        private Manager()
        {
            var defaultLogger = new Logger("default");
            Channels.Add("default", defaultLogger); 
        }

        #nullable enable
        //creates a new channel, if the filepath is given it will write into the file, if not it will write into the console
        public void AddChannel(string channelName, string? filePath)
        {
            if (filePath != null)
            {
                var newLogger = new Logger(channelName, filePath);
                Channels.Add(channelName, newLogger);
            }
            else
            {
                var newLogger = new Logger(channelName);
                Channels.Add(channelName, newLogger);
            }
        }

        private Logger GetLoggerInstance(string channelName)
        {
            foreach (var KeyValue in Channels)
            {
                if (KeyValue.Key.Equals(channelName))
                {
                    return KeyValue.Value;
                }
            }

            throw new Exception("couldn't find channel");
        }
        
        /*Ab hier starten die writer methoden*/
        public void Verbose(string channelName, string message)
        {
            GetLoggerInstance(channelName).Verbose(message);
        }

        public void Info(string channelName, string message)
        {
            GetLoggerInstance(channelName).Info(message);
        }

        public void Warning(string channelName, string message)
        {
            GetLoggerInstance(channelName).Warning(message);
        }

        public void Error(string channelName, string message)
        {
            GetLoggerInstance(channelName).Error(message);
        }

        public void Fatal(string channelName, string message)
        {
            GetLoggerInstance(channelName).Fatal(message);
        }
       
    }
}