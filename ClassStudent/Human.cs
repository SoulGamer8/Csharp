using System;

namespace ClassStudent
{
    class Human
    {
        private Address _address;
        protected string _name { get;private  set; }
        protected string _surname{ get;private set; }
        protected int _age{ get;private set; }
        protected char _sex{  get;private set; }
        
        public Human(string name, string surname, int age, char sex,Address address) 
        {
            _name = name;
            _surname = surname;
            _age = age;
            _sex = sex;
            _address = address;
        }
        
        public void GetInfo() 
        {
            Console.WriteLine("Name {0}\n Surname {1}\n Age {2}\n Sex {3}",
                this._name,this._surname,this._age,this._sex);
        }
        
    }
}