using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class Teacher:Human
    {
        private List<Student> studentsList = new List<Student>();
        private int _limitCounter=0;
        private int _limitStudentList{ get; set; }
        public Teacher(string name,string surname, int age, char sex,Address address,int limitStudentList )  
            : base(name,surname,age,sex,address)
        {
            _limitStudentList = limitStudentList;
            studentsList = new List<Student>(limitStudentList);
        }

        public void AddStudent()
        {
            if (_limitCounter < _limitStudentList)
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
                char sex = Convert.ToChar(Console.ReadLine());
            
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
                studentsList.Add(new Student(name,surname,age,sex,address));
                _limitCounter++;
                Console.WriteLine("Students was added successfully");
            }
            else
                Console.WriteLine("Students limit");
        }

        public void RemoveStudent(string surname)
        {
            if (_limitCounter == 0)
                Console.WriteLine("List empty");
            else
            {
                foreach (Student i in studentsList)
                {
                    if (surname == i.Surname)
                    {
                        studentsList.Remove(i);
                        Console.WriteLine($"Student {0} {1} has succesfully removed.",
                            i.Name,i.Surname);
                        _limitCounter--;
                    }

                }
            }
        }

        public void PrintListStudent()
        {
            int i = 0;
            foreach (Student student in studentsList)
            {
                Console.WriteLine(i + " - " + student.Surname);
            }
        }

        public void GetInfoAboutStudent(int number)
        {
            studentsList[number].GetInfo();
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{0}",this._limitCounter);
        }

        public static bool operator <(Teacher teacher1, Teacher teacher2)
        {
            return teacher1._limitCounter < teacher2._limitCounter;
        }
        public static bool operator >(Teacher teacher1, Teacher teacher2)
        {
            return teacher1._limitCounter > teacher2._limitCounter;
        }
        
    }
}