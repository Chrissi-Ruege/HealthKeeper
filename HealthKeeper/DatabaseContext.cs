using HealthKeeper.Models.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthKeeper
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<StatisticEntry> StatsEntries { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
            Database.Migrate();
        }
    }
}
