using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class TeacherList:Human
    {
        private List<Teacher> _teachers;
        
        public TeacherList(int limit,string name, string surname, int age,char sex,Address address )
            : base(name,surname,age,sex,address) 
        {
            _teachers.Add(new Teacher(limit,name,surname,age,sex,address));
        }
        
        public void RemoveTeacher(string S) 
        {
        }

        public void Sort() 
        {
            _teachers.Sort(); 
        }
    }
}