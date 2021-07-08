using System;
using System.Globalization;

namespace ClinicaMedic.Entities
{
    class Patient : Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Contact Contact { get; set; }

        public Patient() { }

        public Patient(double height, double weight, string name, char sex, string nationality, Contact contact) 
        : base(name, sex, nationality)
        {
            Height = height;
            Weight = weight;
            Contact = contact;
        }

        public double Imc()
        {
            return Weight / (Height * Height);
        }

        public override void PrintFile()
        {
            if (Sex == 'M')
            {
                Console.WriteLine("Sr. " + Name + "\nNaturalness : " + Nationality);
                Console.WriteLine("Fone: " + Contact.Number + "   E-mail: " + Contact.Email);
                Console.WriteLine("IMC: " + Imc().ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Sra. " + Name + "\nNaturalness : " + Nationality);
                Console.WriteLine("Fone: " + Contact.Number + "   E-mail: " + Contact.Email);
                Console.WriteLine("IMC: " + Imc().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
