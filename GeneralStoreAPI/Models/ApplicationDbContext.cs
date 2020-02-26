using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }         //comes with entity framework
        
        public DbSet<Customer> Customers { get; set; }                    //comes with entity framework
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}