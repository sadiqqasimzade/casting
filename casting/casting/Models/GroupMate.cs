using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    internal class GroupMate
    {
        Student[] students= new Student[0];

        public Student this[int index]
        {
            get { return students[index]; }
            set { 
                Array.Resize(ref students,students.Length+1);
                students[index] = value; }
        }

   
        public void Sort() 
        {
            if (students.Length > 1)
            {
                for (int i = 0; i < students.Length - 1; i++)
                    for (int j = 0; j < students.Length - i - 1; j++)
                        if (students[j] < students[j + 1])
                        {
                            Student temp=students[j];
                            students[j]=students[j + 1];
                            students[j+1]=temp;
                        }
            }
            else Console.WriteLine("Min length must be >2");
            Cout();
        }
        public void Cout()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
