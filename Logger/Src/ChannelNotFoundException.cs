using System;

namespace Logger
{
    public class ChannelNotFoundException: Exception
    {
        public ChannelNotFoundException() : base() { }
        public ChannelNotFoundException(string message) : base(message) { }
        public ChannelNotFoundException(string message, Exception inner) : base(message, inner) { }

    }
}