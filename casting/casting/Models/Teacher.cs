using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    internal class Teacher : Person
    {
        public double Salary { get; set; }


        public Teacher(string name, string surname, byte age, double salary) 
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        public static void SalaryInput(out double salary)
        {
            do
            {
                SetSalaryPoint:
                try
                {
                    Console.Write("Salary must be greater than 0\nSalary:");
                    salary = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetSalaryPoint;
                }
            } while (salary<=0);
        }

        public override string ShowInfo()
        {
            return $"---------------\n{this.GetType().Name}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nSalary:{Salary}";
        }

        public static Teacher operator >(Teacher teacher1, Teacher teacher2)
        {
            if (teacher1.Salary > teacher2.Salary) return teacher1;
            else return teacher2;
        }
        public static Teacher operator <(Teacher teacher1, Teacher teacher2)
        {
            if (teacher2.Salary > teacher1.Salary) return teacher2;
            else return teacher1;
        }
    }
}
