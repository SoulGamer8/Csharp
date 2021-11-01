using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        private Address _address;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }


        public Address Address
        {
            get
            {
                return _address;
            }
        }

        public User(string name, string surname, int age, string sex, Address address)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
            _address = address;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name {0}\nSurname {1}\nAge {2}\nSex {3}",
                Name, Surname, Age, Sex);
            _address.GetInfo();
        }
    }
}
