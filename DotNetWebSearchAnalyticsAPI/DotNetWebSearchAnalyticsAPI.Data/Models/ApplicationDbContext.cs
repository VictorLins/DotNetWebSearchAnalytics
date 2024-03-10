using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebSearchAnalyticsAPI.Data.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions prDbContextOptions) : base(prDbContextOptions)
        {

        }

        public DbSet<SearchTransaction> SearchTransactions { get; set; }
    }
}