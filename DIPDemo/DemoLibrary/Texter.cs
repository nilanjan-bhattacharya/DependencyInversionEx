using DemoLibrary.Interface;
using System;

namespace DemoLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"Sent text to {owner.Number}");
        }
    }
}
