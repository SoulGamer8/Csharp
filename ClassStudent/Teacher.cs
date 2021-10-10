using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class Teacher:Human
    {
        private List<Student> studentsList{ get; set; }
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
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                int age = Convert.ToInt16(Console.ReadLine());
                char sex = Convert.ToChar(Console.ReadLine());

                string country=Console.ReadLine();
                string district=Console.ReadLine();
                string city=Console.ReadLine();
                string street=Console.ReadLine();
                string housenumber=Console.ReadLine();
                
                Address address = new Address(country,district,city,street,housenumber);
                Student student = new Student(name,surname,age,sex,address);
                studentsList.Insert(0,student);
                _limitCounter++;
                Console.WriteLine("Done");
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
            foreach (var i in studentsList)
            {
                Console.WriteLine(i);
            }
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