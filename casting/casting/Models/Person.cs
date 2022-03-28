using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace casting.Models
{
    abstract class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person()
        {
            Id = _id;
            _id++;
        }
        abstract public string ShowInfo();
        public override string ToString()
        {
            return ShowInfo();
        }
        public static void NameInput(out string name)
        {
            Regex regex = new Regex("^[A-Z]+[a-z]+$");
            do
            {
                Console.WriteLine("Name must start with upper letter and after contain olny lower letters");
                Console.Write("Name:");
                name = Console.ReadLine();
            } while (!regex.IsMatch(name));
        }

        public static void SurnameInput(out string surname)
        {
            Regex regex = new Regex("^[A-Z]+[a-z]+$");
            do
            {
                Console.WriteLine("Surname must start with upper letter and after contain olny lower letters");
                Console.Write("Surname:");
                surname = Console.ReadLine();
            } while (!regex.IsMatch(surname));
        }

        public static byte AgeInput(byte agemin, byte agemax = 122) //byte 0-255, 
        {
                byte age;
            do
            {
            SetAgePoint:
                try
                {
                    Console.Write($"Age must be beetwen {agemin} - {agemax}\nAge:");
                    age = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetAgePoint;
                }
            } while (age<agemin||age>agemax);
            return age;
        }

    }
}
