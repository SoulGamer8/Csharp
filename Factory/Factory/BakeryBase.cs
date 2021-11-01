namespace Factory
{
    abstract class BakeryBase
    {
        public string Name { get; protected set; }

        public BakeryBase(string name)
        {
            Name = name;
        }

        
        
        abstract public DoughnutBase Create();
    }
}