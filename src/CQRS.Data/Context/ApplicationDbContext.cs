using CQRS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=CQRS.Example;Trusted_Connection=true;MultipleActiveResultSets=true;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Customer>().ToTable("Customers").HasMany(i => i.Orders).WithOne(i => i.Customer).HasForeignKey(i => i.CustomerId);
            modelBuilder.Entity<Customer>().HasOne(i => i.CustomerPhone).WithOne(i => i.Customer).HasForeignKey<Customer>(i => i.CustomerPhoneId);
            modelBuilder.Entity<CustomerPhone>().ToTable("CustomerPhones");
            modelBuilder.Entity<Order>().ToTable("Orders").HasOne(i => i.Customer).WithMany(i => i.Orders).HasForeignKey(i => i.CustomerId);
            modelBuilder.Entity<OrderProduct>().ToTable("OrderProducts");
            modelBuilder.Entity<OrderProduct>().HasOne(i => i.Order).WithMany(i => i.OrderProducts).HasForeignKey(i => i.OrderId);
            modelBuilder.Entity<OrderProduct>().HasOne(i => i.Product).WithMany().HasForeignKey(i => i.ProductId);
            modelBuilder.Entity<Product>().ToTable("Products");


            base.OnModelCreating(modelBuilder);
        }
    }
}
