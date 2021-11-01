namespace Factory
{
    class ChocolateBakery : BakeryBase
    {
        public ChocolateBakery(string name)
            :base(name)
        {
            
        }

        public override DoughnutBase Create()
        {
            return new ChocolateDoughnut();
        }
    }
}