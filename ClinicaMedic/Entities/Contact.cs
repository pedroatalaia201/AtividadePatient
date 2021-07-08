using System;

namespace ClinicaMedic.Entities
{
    class Contact
    {
        public string Number { get; set; }
        public string Email { get; set; }

        public Contact() { }

        public Contact(string number) 
        {
            Number = number;
            Email = null;
        }

        public Contact(string number, string email)
        {
            Number = number;
            Email = email;
        }
    }
}
