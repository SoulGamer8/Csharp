using System;

namespace ClassStudent
{
    class Human
    {
        private Address _address;
        private string _name;
        private string _surname;
        private int _age{ get; set; }
        private char _sex{  get; set; }
        
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public string Surname
        {
            set
            {
                _surname = value;
            }
            get
            {
                return _surname;
            }
        }
        
        public Human(string name, string surname, int age, char sex,Address address) 
        {
            _name = name;
            _surname = surname;
            _age = age;
            _sex = sex;
            _address = address;
        }
        
        public virtual void GetInfo() 
        {
            Console.WriteLine("Name {0}\nSurname {1}\nAge {2}\nSex {3}",
                this._name,this._surname,this._age,this._sex);
            _address.GetInfo();
        }
        
    }
}