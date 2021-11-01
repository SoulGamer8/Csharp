using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            KitchenStove kitchenStove = new KitchenStove();
            kitchenStove.Start("Gas");
            Console.WriteLine(kitchenStove.Fuel.Type);
            
            kitchenStove.Fuel  = Fuel.getInstance("Power");
            Console.WriteLine(kitchenStove.Fuel.Type);
            
        }
    }
}