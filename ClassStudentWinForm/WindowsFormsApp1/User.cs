using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public Address Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        protected User(int id,string name, string surname, int age, string sex, Address address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
            Address = address;
        }

    }
}
