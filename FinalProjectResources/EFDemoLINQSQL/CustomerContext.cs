using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQSQL
{
    internal class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RankenCustomers;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData
                (
                    new Customer { CustomerID = 1, CustomerName = "Susan Smith", Address="123 Any Street", Budget = 10000 },
                    new Customer { CustomerID = 2, CustomerName = "Mike Jackson", Address = "456 Any Street", Budget = 20000 },
                    new Customer { CustomerID = 3, CustomerName = "Larry Jones", Address = "789 Any Street", Budget = 30000 }
                );
        }
    }
}
