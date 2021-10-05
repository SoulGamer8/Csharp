using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class TeacherList
    {
        private List<Teacher> _teachers;
        
        public void TeacherAdd(int limit,string name, string surname, int age,char sex,Address address )
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