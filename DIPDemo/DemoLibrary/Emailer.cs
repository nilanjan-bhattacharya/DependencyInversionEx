using DemoLibrary.Interface;
using System;

namespace DemoLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"Sent mail to {owner.EmailId}");
        }
    }
}
