namespace Singleton
{
    public class KitchenStove
    {
        public Fuel Fuel { get; set; }


        public void Start(string fuelType)
        {
            Fuel= Fuel.getInstance(fuelType);
        }
    }
}