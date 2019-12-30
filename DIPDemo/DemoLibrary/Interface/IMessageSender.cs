namespace DemoLibrary.Interface
{
    public interface IMessageSender
    {
        void SendMessage(IPerson owner, string message);
    }
}