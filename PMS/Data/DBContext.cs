using System;
using Microsoft.EntityFrameworkCore;

namespace PMS.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options)
        {
        }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<PurchaseRequisition> PurchaseRequisition { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; } 
    }
}
