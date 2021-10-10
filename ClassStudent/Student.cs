using System;

namespace ClassStudent
{
    class Student : Human
    {
        private int[] _evaluationArray;
        private Marks marks;

        public Student(string name,string surname, int age, char sex,Address address)
            : base(name,surname,age,sex,address)
        {
            marks = StudentType();
        }
        
        private Marks StudentType()
        {
            int avenger = Avenger();
            switch (avenger) 
            {
                case 5:
                    return (Marks.A);
                case 4:
                    return(Marks.B);
                case 3:
                    return(Marks.C);
                case 2:
                    return(Marks.D);
                default:
                    return(Marks.F);
            }
        }
        
        private int Avenger()
        {
            RandomMark();
            int sum = 0;
            for (int i = 0; i < _evaluationArray.Length; i++)
                sum += _evaluationArray[i];
            return sum / _evaluationArray.Length;
        }
        
        private void RandomMark()
        {
            _evaluationArray = new int[10];
            Random rnd = new Random();
            for (int i=0; i < _evaluationArray.Length;i++)
            {
                _evaluationArray[i] = rnd.Next(1, 5);
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"mark: {0}",this.marks);
        }

        public static bool operator <(Student student1, Student student2)
        {
            return student1.marks < student2.marks;
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.marks > student2.marks;
        }
    }
}