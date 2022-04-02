namespace Logger
{
    public interface IChannel
    {
        public void Debug3(string message);
        public void Debug2(string message);
        public void Debug1(string message);
        public void Info(string message);
    }
}