using Microsoft.AspNetCore.Identity;

namespace HealthKeeper.Models.Database;

public class StatisticEntry
{
    public int Id { get; set; }
    public string? UserId { get; set; }
    public DateTime Timestamp { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public virtual IdentityUser? User { get; set; }
}