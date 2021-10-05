using System;
using System.Collections;

namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("Anton","Orekhov",20,'M',new Address("Ukrain","Kherson","Kherson","Ivano Boguna","58A"));
            student.GetInfo();


            while (true)
            {
                Console.WriteLine("1 - Add teacher.\n2 - Serch teacher.\n3-  ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        TeacherList.TeacherAdd();
                }
            }
        }
    }
}