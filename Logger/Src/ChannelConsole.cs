using System;

namespace Logger
{
    public class ChannelConsole: IChannel
    {
        public string GetName()
        {
            return "Console";
        }

        public void Debug3(string message)
        {
            Console.WriteLine($"[Debug3] {message}");
        }

        public void Debug2(string message)
        {
            Console.WriteLine($"[Debug2] {message}");
        }

        public void Debug1(string message)
        {
            Console.WriteLine($"[Debug1] {message}");
        }

        public void Info(string message)
        {
            Console.WriteLine($"[Info] {message}");
        }
    }
}