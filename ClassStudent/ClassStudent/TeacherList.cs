using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class TeacherList
    {
        private List<Teacher> teachersList=new List<Teacher>();

        public List<Teacher> TeachersList
        {
            get
            {
                return teachersList;
            }
        }
        
        public void AddAll()
        {
            teachersList.Add(new Teacher("name","surname", 5, "sex", new Address("Ukr","Kherson","Kherson","Tyt","51f"), 3));
        }
        public void TeacherAdd()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            
            
            Console.Write("Age: ");
            string enteredAge = Console.ReadLine();
            int age;
            while(!int.TryParse(enteredAge,out age))
            {
                Console.Write("Isn`t number. Try again. Age: ");
                enteredAge = Console.ReadLine();
            }

            Console.Write("Sex: ");
            string sex = Console.ReadLine();
            
            Console.Write("Limit: ");
            string enteredlimit = Console.ReadLine();
            int limit;
            while(!int.TryParse(enteredlimit,out limit))
            {
                Console.Write("Isn`t number. Try again. Limit: ");
                enteredlimit = Console.ReadLine();
            }
            
            Console.Write("Country: ");
            string country=Console.ReadLine();
            Console.Write("District: ");
            string district=Console.ReadLine();
            Console.Write("City: ");
            string city=Console.ReadLine();
            Console.Write("Street: ");
            string street=Console.ReadLine();
            Console.Write("Housenumber: ");
            string housenumber=Console.ReadLine();
            
            Address address = new Address(country,district,city,street,housenumber);
            teachersList.Add(new Teacher(name, surname, age, sex, address, limit));
            Console.WriteLine("Teacher was added successfully");
        }
        
        public void RemoveTeacher(int number) 
        { 
            teachersList.RemoveAt(number);
            Console.WriteLine("Teacher {0} {1} successfully deleted ",
                teachersList[number].Name, teachersList[number].Surname );
        }
        
        public void PrintLIstTeacher()
        {
            if (teachersList.Count == 0)
            {
                Console.WriteLine("Empty list");
            }
            foreach (Teacher teacher in teachersList)
            {
                Console.WriteLine(teachersList.IndexOf(teacher) + " - " + teacher.Surname);
            }
        }
        
        public void PrintInfoTeacher(int number) 
        {
            teachersList[number].GetInfo();
        }

        public int FindTeacher(string surname,string name )
        {
            foreach (Teacher teacher in teachersList)
            {
                if (surname == teacher.Surname && name == teacher.Name)
                {
                    return teachersList.IndexOf(teacher);
                }
            }

            return -1;
        }

        public void Sort()
        {
            teachersList.Sort(new HumanComparer());
            Console.WriteLine("Successfully sorted ");
        }
    }
}