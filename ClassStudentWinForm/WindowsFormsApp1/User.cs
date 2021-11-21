using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class User
    {
        public Address Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string PathToPhoto { get; set; }

        protected User(int id,string name, string surname, int age, string sex, Address address,string pathToPhoto)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
            Address = address;
            PathToPhoto=pathToPhoto;
        }

    }
}
