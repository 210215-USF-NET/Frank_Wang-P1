using Microsoft.EntityFrameworkCore;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    //Inhereting DBContext, establishing is-a relationship
    public class StoreDBContext : DbContext
    {
        //Build Conecvtion to db
        public StoreDBContext(DbContextOptions options) : base(options)
        {

        }
        protected StoreDBContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(Customer => Customer.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Location>()
                .Property(location => location.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(product => product.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Inventory>()
               .Property(Inventory => Inventory.Id)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
               .Property(order => order.Id)
               .ValueGeneratedOnAdd();

        }
    }
}
