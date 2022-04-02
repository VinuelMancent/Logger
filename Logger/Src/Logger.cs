using System;
using Serilog;

namespace Logger.Src
{
    public class Logger
    {
        private Serilog.Core.Logger log;
        private string channelName;
        //Constructor
        public Logger(string channelName)
        {
            this.channelName = channelName;
            
            log = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Verbose()
                .CreateLogger();
        }
        //Constructor for logging into a file
        public Logger(string channelName, string filePath)
        {
            this.channelName = channelName;
            log = new LoggerConfiguration()
                .WriteTo.File(filePath)
                .MinimumLevel.Verbose()
                .CreateLogger();
        }
        
        //getter for the channelName
        public string GetChannelName()
        {
            return channelName;
        }
        
        //Ab hier starten die logger methoden
        public void Verbose(string message)
        {
            log.Verbose(message);
        }

        public void Info(string message)
        {
            log.Information(message);
        }

        public void Warning(string message)
        {
            log.Warning(message);
        }

        public void Error(string message)
        {
            log.Error(message);
        }

        public void Fatal(string message)
        {
            log.Fatal(message);
        }
    }
}