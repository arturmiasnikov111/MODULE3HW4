using System;
using System.Threading;

namespace MODULE3HW4.Models
{
    public class User
    {
        public int UniqueNumber { get;}
        public string Number { get; init; }
        
        public int Age { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        
        public static int Id = 0;

        public User()
        {
            Id++;
            UniqueNumber = Id;
        }
    }
}