using DemoLibrary.Interface;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        ILogger _log;
        IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public Chore(ILogger log, IMessageSender messageSender)
        {
            _log = log;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _log.Log($"Performed on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _log.Log($"Completed { ChoreName }");

            _messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
