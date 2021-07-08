using System;

namespace ClinicaMedic.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public  char Sex { get; set; }
        public string Nationality { get; set; }

        public Person() { }

        public Person(string name, char sex, string nationality)
        {
            Name = name;
            Sex = sex;
            Nationality = nationality;
        }

        public abstract void PrintFile();
    }
}
