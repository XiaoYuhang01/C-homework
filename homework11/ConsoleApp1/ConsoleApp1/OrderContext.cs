namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrderContext : DbContext
    {
        public OrderContext()
            : base("Orderdatabase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Cargo> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }

}