using System.Data.Entity;
using DesignPatternExamples.Models;

namespace DesignPatternExamples.DataAccess
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}