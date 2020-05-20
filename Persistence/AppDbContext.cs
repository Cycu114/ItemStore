using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ItemStoreProject.Persistence
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}