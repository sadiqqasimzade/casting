using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    internal class Student : Person
    {
        public double Point { get; set; }

        public Student(string name, string surname, byte age, double point):base()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }

        public static void PointInput(out double point)
        {
            do
            {
            SetPoint:
                try
                {
                    Console.Write("Points must be between 0-100\nPoints:");
                    point = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetPoint;
                }
            } while (point > 100 || point < 0);
        }

        public override string ShowInfo()
        {
            return $"---------------\n{this.GetType().Name}\nName:{Name}\nSurname:{Surname}\nId:{Id}\nAge:{Age}\nPoint:{Point}";
        }

        public static bool operator >(Student student1, Student student2)
        {
            if (student1.Point > student2.Point) return true;
            else return false;
        }
        public static bool operator <(Student student1, Student student2)
        {
            if (student2.Point > student1.Point) return true;
            else return false;
        }
    }
}
