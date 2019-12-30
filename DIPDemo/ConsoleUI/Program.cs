using DemoLibrary.Interface;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.Firstname = "Nilanjan";
            owner.LastName = "Bhattacharya";
            owner.EmailId = "nilanjan@example.com";

            IChore chore = Factory.CreateChore();
            chore.Owner = owner;
            chore.ChoreName = "Throw the garbage";

            chore.PerformedWork(1);
            chore.CompleteChore();
        }
    }
}
