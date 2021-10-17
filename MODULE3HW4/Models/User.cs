using System;

namespace MODULE3HW4.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Number { get; init; }
        
        public int Age { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public User()
        {
        }
    }
}