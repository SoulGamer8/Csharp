namespace Factory
{
    class CherryBakery:BakeryBase
    {
        public CherryBakery(string name)
            :base(name)
        {
            
        }

        public override DoughnutBase Create()
        {
            return new CherryDoughnut();
        }
    }
}