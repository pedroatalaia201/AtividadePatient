using System;
using System.Globalization;
using System.Collections.Generic;
using ClinicaMedic.Entities;

namespace ClinicaMedic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            int op = 0;

            while(op != 3)
            {
                Console.WriteLine("\n1- Register Patient;\n2-List Patients;\n3- Exit");
                op = int.Parse(Console.ReadLine());

                if(op == 1)
                {
                    Console.Write("Write the Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Sex(M/F): ");
                    char sex = char.Parse(Console.ReadLine());

                    Console.Write("Nationality: ");
                    string nation = Console.ReadLine();

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number: ");
                    string number = Console.ReadLine();

                    Console.Write("The patient have an e-mail?(y/n) ");
                    char option = char.Parse(Console.ReadLine());

                    if(option == 'y')
                    {
                        Console.Write("E-mail: ");
                        string email = Console.ReadLine();

                        Contact contact = new Contact(number, email);
                        person.Add(new Patient(height, weight, name, sex, nation, contact));                       
                    }
                    else
                    {
                        Contact contact = new Contact(number);
                        person.Add(new Patient(height, weight, name, sex, nation, contact));                                           
                    }
                }
                Console.WriteLine(" ");
                if (op == 2)
                {
                    foreach(Patient patient in person)
                    {
                        patient.PrintFile();
                    }
                }
            }
        }
    }
}
