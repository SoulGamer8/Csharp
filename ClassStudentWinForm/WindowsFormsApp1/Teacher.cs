using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Teacher:User
    {
        private List<Student> studentsList = new List<Student>();
        private int _limitCounter = 0;

        public List<Student> StudentsList
        {
            get
            {
                return studentsList;
            }
        }

        public int LimitStudentList { get; set; }
      

        public Teacher(int id,string name, string surname, int age, string sex, Address address, int limitStudentList)
            : base(id,name, surname, age, sex, address)
        {
            LimitStudentList = limitStudentList;
            studentsList = new List<Student>(limitStudentList);
        }

        public void AddStudent(int id ,string name, string surname,int age, string sex, string country, string district, string city , string street , string housenumber, string marks)
        {
            studentsList.Add(new Student(id,name, surname, age, sex, new Address(country, district, city , street , housenumber), marks));
            _limitCounter++;
        }

        public void RemoveStudent(int number)
        {
            studentsList.RemoveAt(number);
        }

        public int FindStudent(string surname, string name)
        {
            foreach (Student students in studentsList)
            {
                if (surname == students.Surname && name == students.Name)
                {
                    return studentsList.IndexOf(students);
                }
            }

            return -1;
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
