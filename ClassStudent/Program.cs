using System;
using System.Collections;

namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            TeacherList teacherList = new TeacherList();
            Teacher teacher = new Teacher("Bob","Bob",20,'M',new Address("Ukr","Kherson","Kherson","Tyt","78A"),10);
            while (true)
            {
                Console.WriteLine("1 - Add teacher.\n" +
                                  "2 - Remove Teacher.\n" +
                                  "3 - Sort\n" +
                                  "4 - Print LIst Teacher\n" +
                                  "5 - Add Student\n" +
                                  "6 - Remove Student\n" +
                                  "7 - Print List Student\n" +
                                  "8 - Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        teacherList.TeacherAdd();
                        break;
                    case 2:
                        string surname = Console.ReadLine();
                        teacherList.RemoveTeacher(surname);
                        break;
                    case 3:
                        teacherList.Sort();
                        break;
                    case 4:
                        teacherList.PrintLIstTeacher();
                        break;
                    case 5:
                        teacher.AddStudent();
                        break;
                    case 6: 
                        surname = Console.ReadLine();
                        teacher.RemoveStudent(surname);
                        break;
                    case 7:
                        teacher.PrintListStudent();
                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}