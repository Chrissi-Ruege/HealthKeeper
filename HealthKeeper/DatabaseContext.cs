using HealthKeeper.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace HealthKeeper
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HealthKeeper;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<StatisticEntry> StatsEntries { get; set; }
    }
}
