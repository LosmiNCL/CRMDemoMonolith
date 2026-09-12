using Microsoft.EntityFrameworkCore;
using CRMDemoMonolith.Core.Domain.Entities;

namespace CRMDemoMonolith.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().ToTable(nameof(Company));
        }
    }
}
