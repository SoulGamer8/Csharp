using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class TeacherList
    {
        private List<Teacher> teachersList;
        
        public void TeacherAdd()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("age:");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("sex:");
            char sex = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("country:");
            string country=Console.ReadLine();
            Console.WriteLine("district:");
            string district=Console.ReadLine();
            Console.WriteLine("city:");
            string city=Console.ReadLine();
            Console.WriteLine("street:");
            string street=Console.ReadLine();
            Console.WriteLine("housenumber:");
            string housenumber=Console.ReadLine();
            
            Address address = new Address(country,district,city,street,housenumber);
            Teacher teacher = new Teacher(name, surname, age, sex, address, limit);
            teachersList.Insert(0,teacher);
        }
        
        public void RemoveTeacher(string surname) 
        { 
            foreach (Teacher i in teachersList)
            {
                if (surname == i.Surname)
                {
                    teachersList.Remove(i);
                    Console.WriteLine($"teacher {0} {1} has succesfully removed.",
                        i.Name,i.Surname);
                    return ;
                }

            }
        }

        public void Sort() 
        {
            teachersList.Sort(); 
        }
        
        public void PrintLIstTeacher() 
        {
            foreach (Teacher i in teachersList)
            {
                i.GetInfo();
            }
        }
    }
}