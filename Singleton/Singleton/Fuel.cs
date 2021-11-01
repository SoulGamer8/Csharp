namespace Singleton
{
    public class Fuel
    {
        private static Fuel instance;
        
        public  string Type { get; private set; }

        protected Fuel(string type)
        {
            Type = type;
        }

        public static Fuel getInstance(string type)
        {
            if (instance == null)
                instance = new Fuel(type);
            return instance;
        }
    }
}