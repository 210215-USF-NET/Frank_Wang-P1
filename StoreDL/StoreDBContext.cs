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
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(Customer => Customer.PhoneNumber)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .HasOne(Customer => Customer.FirstName)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
