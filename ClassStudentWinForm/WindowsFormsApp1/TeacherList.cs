using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TeacherList
    {
        private List<Teacher> teachersList = new List<Teacher>();

        public List<Teacher> TeachersList
        {
            get
            {
                return teachersList;
            }
        }

        public void AddAll()
        {
            teachersList.Add(new Teacher("name", "surname", 5, "sex", new Address("Ukr", "Kherson", "Kherson", "Tyt", "51f"), 3));
            teachersList.Add(new Teacher("name2", "surname2", 7, "sex2", new Address("Ukr2", "Kherson2", "Khe2rson", "Tyt2", "51f2"), 3));
        }
        public void TeacherAdd(string name, string surname,int  age, string sex)
        {
            teachersList.Add(new Teacher(name, surname, age, sex, new Address("f", "q", "e", "r", "f"), 5));
        }

        public void RemoveTeacher(int number)
        {
            teachersList.RemoveAt(number);
            Console.WriteLine("Teacher {0} {1} successfully deleted ",
                teachersList[number].Name, teachersList[number].Surname);
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

        public int FindTeacher(string surname, string name)
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
        /*
        public void Sort()
        {
            teachersList.Sort(new HumanComparer());
            Console.WriteLine("Successfully sorted ");
        }*/
    }
}
