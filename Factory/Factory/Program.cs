namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryBase donutFactory = new ChocolateBakery("Chocolate");
            DoughnutBase donut = donutFactory.Create();

            donut.Info();

            donutFactory = new CherryBakery("Cherry");
            donut = donutFactory.Create();

            donut.Info();
        }
    }
}