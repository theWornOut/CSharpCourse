namespace EntityFrameworkDemo
{
    using System.Data.Entity;

    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}