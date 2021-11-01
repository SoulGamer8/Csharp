using System.Data.Entity;



namespace WindowsFormsApp1
{
    class ListContext : DbContext
    {
        public ListContext(): base("DefaultConnection")
        { }

        public DbSet<Player> Players { get; set; }

    }
}
