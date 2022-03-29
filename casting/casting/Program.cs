using System;
using casting.Models;
namespace casting
{
    internal class Program
    {
        static void Main()
        {
            sbyte choise;
            Person[] students = new Student[0];
            Person[] teachers = new Teacher[0];
            //Debug rahat olsun deye =) ps:studentin olcusunu deyismek lazimdi
            //students[0] = new Student("Sadiq", "Mvp", 14, 55);
            //students[1] = new Student("Sadiq", "Mvp", 14, 65);
            //students[2] = new Student("Sadiq", "Mvp", 14, 5);
            //students[3] = new Student("Sadiq", "Mvp", 14, 95);
            //students[4] = new Student("Sadiq", "Mvp", 14, 15);
            do
            {
            ChoisePoint:
                try
                {
                    Console.Write("-------------\n1)Create Student\n2)Create Teacher\n3)Show all Info\n4)Work with Group\n5)Compare salarys\nChoise:");
                    choise = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ChoisePoint;
                }

                switch (choise)
                {
                    case 0: break;
                    case 1: //Create student
                        Person.NameInput(out string studentname);
                        Person.SurnameInput(out string studentsurname);
                        byte studentage = Person.AgeInput(6, 20);
                        Student.PointInput(out double point);
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = new Student(studentname, studentsurname, studentage, point);
                        break;
                    case 2: //Create teacher
                        Person.NameInput(out string teachername);
                        Person.SurnameInput(out string teachersurname);
                        byte teacherage = Person.AgeInput(18, 65);
                        Teacher.SalaryInput(out double salary);
                        Array.Resize(ref teachers, teachers.Length + 1);
                        teachers[teachers.Length - 1] = new Teacher(teachername, teachersurname, teacherage, salary);
                        break;
                    case 3: //ShowInfo
                        foreach (var person in students)
                            Console.WriteLine(person);
                        foreach (var person in teachers)
                            Console.WriteLine(person);
                        break;
                    case 4: //GroupMate

                        GroupMate groupMate = new GroupMate();
                        byte index = 0;
                        do
                        {
                        ChoisePoint1:
                            try
                            {
                                Console.Write("-------------\n1)Add 1 student to group\n2)Sort Students by Points \n3)Show sorted students\nChoise:");
                                choise = Convert.ToSByte(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto ChoisePoint1;
                            }

                            switch (choise)
                            {
                                case 0: break;
                                case 1: //Add 1 student to group            //TODO!!!!!!!!!!!!!

                                    try
                                    {
                                        if (students.Length < index + 1) throw new Exception("No students left");
                                        groupMate[index] = (Student)students[index];
                                        index++;
                                        Console.WriteLine("Student added");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine( ex.Message);
                                    }
                                    break;
                                case 2: //Sort Students by Points
                                    groupMate.Sort();
                                    break;
                                case 3: //Show sorted students
                                    groupMate.Cout();
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input");
                                    break;
                            }

                        } while (choise != 0);
                        break;
                    case 5: // Compare salarys

                        try
                        {
                            if (teachers.Length < 2) throw new Exception("Min length is 2");
                            Console.WriteLine($"Theacher 1 has more salary:{(Teacher)teachers[0] > (Teacher)teachers[1]}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);
        }
    }
}
