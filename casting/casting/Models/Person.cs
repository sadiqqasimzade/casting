using System;
using System.Collections.Generic;
using System.Text;

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
            
            do
            {
                Console.WriteLine("Name example:X Æ A-12");
                Console.Write("Name:");
                name = Console.ReadLine();
            } while (String.IsNullOrEmpty(name)||String.IsNullOrWhiteSpace(name));
            char[] arr = name.Trim().ToCharArray();
            arr[0] = Char.ToUpper(arr[0]);
            name=String.Concat(arr);
        }

        public static void SurnameInput(out string surname)
        {
            do
            {
                Console.Write("Surname:");
                surname = Console.ReadLine();
            } while (String.IsNullOrEmpty(surname) || String.IsNullOrWhiteSpace(surname));
            char[] arr = surname.Trim().ToCharArray();
            arr[0] = Char.ToUpper(arr[0]);
            surname = String.Concat(arr);
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
