using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class Teacher:Human
    {
        private List<Student> studentsList;
        private int _limitCounter=0;
        private int _limitStudentList;
        public Teacher(int limitStudentList,string name,string surname, int age, char sex,Address address )  
            : base(name,surname,age,sex,address)
        {
            _limitStudentList = limitStudentList;
            studentsList = new List<Student>(limitStudentList);
        }

        public void AddStudent(Student student)
        {
            if (_limitCounter < _limitStudentList)
            {
                studentsList.Insert(0,student);
                _limitCounter++;
                Console.WriteLine("Done");
            }
            else
                Console.WriteLine("Students limit");
        }

        public void RemoveStudent(Student student)
        {
            if (_limitCounter == 0)
                Console.WriteLine("List empty");
            else
            {
                studentsList.Remove(student);
                _limitCounter--;
                Console.WriteLine("Done!");
            }
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