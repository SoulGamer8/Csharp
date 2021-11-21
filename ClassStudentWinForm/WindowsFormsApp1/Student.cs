using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student:User
    {
        public string Marks;
        public Student(int id,string name, string surname, int age, string sex, Address address, string marks,string pathToPhoto)
            : base(id, name, surname, age, sex, address, pathToPhoto)
        {
            Marks = marks;
        }
        /*
        public static bool operator <(Student student1, Student student2)
        {
            return student1.age < student2.age;
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.age > student2.age;
        }*/
    }
}