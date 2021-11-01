using System;

namespace Factory
{
    abstract class DoughnutBase
    {
        public string Name { get; protected set; }
        public  int Cost { get; protected set; }

        public DoughnutBase(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
        
        public void Info() 
        {
            Console.WriteLine(this.Name + " " + this.Cost);
        }

    }
}