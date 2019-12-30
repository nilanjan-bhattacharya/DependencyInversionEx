using DemoLibrary.Interface;

namespace DemoLibrary
{
    public class Person : IPerson
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Number { get; set; }
    }
}
