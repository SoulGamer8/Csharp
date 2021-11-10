using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student:User
    {
        public string Marks;

        public Student(string name, string surname, int age, string sex, Address address, string marks)
            : base(name, surname, age, sex, address)
        {
            Marks = marks;
        }
        /*
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Marks < student2.Marks;
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.Marks > student2.Marks;
        }*/
    }
}