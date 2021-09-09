using System;
using EnumComposit.entities.Enums;

namespace EnumComposit.entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public OderStatus Status { get; set; }

        public Client() {}

        public Client(string name, string email, DateTime birthday) {
            Name = name;
            Email = email;
            Birthday = birthday;
        }
    }
}