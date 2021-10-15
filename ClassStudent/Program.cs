using System;
using System.Collections;

namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            TeacherList teacherList = new TeacherList();
            while (true)
            {
                string surname;
                int number;
                Console.WriteLine("1 - Add teacher.\n" +
                                  "2 - Remove Teacher.\n" +
                                  "3 - Sort\n" +
                                  "4 - Print List Teacher\n" +
                                  "5 - Print all info about Teacher\n" +
                                  "6 - Add Student\n" +
                                  "7 - Remove Student\n" +
                                  "8 - Print List Student\n" +
                                  "9 - Exit");
                Console.WriteLine("Work with\n " +
                                  "1 - student\n " +
                                  "2 - teacher\n" +
                                  "3 - Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("1 - Add teacher.\n" +
                                          "2 - Remove Teacher.\n" +
                                          "3 - Sort\n" +
                                          "4 - Print List Teacher\n" +
                                          "5 - Print all info about Teacher\n" +
                                          "6 - Return");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                teacherList.TeacherAdd();
                                break;
                            case 2:
                                Console.WriteLine("");
                                number = Convert.ToInt32(Console.ReadLine());
                                teacherList.RemoveTeacher(number);
                                break;
                            case 3:
                                teacherList.Sort();
                                break;
                            case 4:
                                teacherList.PrintLIstTeacher();
                                break;
                            case 5:
                                Console.WriteLine("");
                                number = Convert.ToInt32(Console.ReadLine());
                                teacherList.PrintInfoTeacher(number);
                                break;
                            default:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("1 - Add Student\n" +
                                          "2 - Remove Student\n" +
                                          "3 - Print List Student\n" +
                                          "4 - Return");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine("");
                                number = Convert.ToInt32(Console.ReadLine());
                                teacherList.teachersList[number].AddStudent();
                                break;
                            case 2:
                                Console.WriteLine("");
                                surname = Console.ReadLine();
                                number = Convert.ToInt32(Console.ReadLine());
                                teacherList.teachersList[number].RemoveStudent(surname);
                                break;
                            case 3:
                                number = Convert.ToInt32(Console.ReadLine());
                                teacherList.teachersList[number].PrintListStudent();
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }

            }
        }
    }
}