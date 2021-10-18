using System;

namespace ClassStudent
{
    class Human
    {
        private Address _address;
        public string Name { get;set; }
        public string Surname{ get;set; }
        public int Age{ get;set; }
        public string Sex{ get;set; }
        
        
        public Address Address
        {
            get
            {
                return _address;
            }
        }
        
        public Human(string name, string surname, int age, string sex,Address address) 
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
                Name,Surname,Age,Sex);
            _address.GetInfo();
        }
        
    }
}