using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using IntrogamiAPI.Models;

namespace IntrogamiAPI.Models
{
    public class IntrogamiAPIDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public IntrogamiAPIDBContext(DbContextOptions<IntrogamiAPIDBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("IntrogamiService");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Following> Emails { get; set; } = null!;
    }
}
