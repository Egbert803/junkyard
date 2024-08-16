using Microsoft.EntityFrameworkCore;
using junkyard.Domain.Entities.Models;
using junkyard.Domain.Entities.Data.Configurations;

namespace junkyard.Domain.Entities.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
