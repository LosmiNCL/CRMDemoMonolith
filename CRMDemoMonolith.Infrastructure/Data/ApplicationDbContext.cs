using Microsoft.EntityFrameworkCore;
using CRMDemoMonolith.Core.Domain.Entities;

namespace CRMDemoMonolith.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
    }
}
