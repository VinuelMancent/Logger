using System;
using Serilog;

namespace Logger.Src
{
    public class Logger
    {
        private Serilog.Core.Logger log;
        private string channelName = "";
        //Constructor
        #nullable enable
        public Logger(string channelName)
        {
            this.channelName = channelName;
            
            log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }
        //Constructor for logging into a file
        public Logger(string channelName, string filePath)
        {
            this.channelName = channelName;
            log = new LoggerConfiguration()
                .WriteTo.File(filePath)
                .CreateLogger();
           
        }
    }
}