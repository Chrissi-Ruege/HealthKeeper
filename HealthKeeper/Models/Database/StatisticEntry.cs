using Microsoft.AspNetCore.Identity;

namespace HealthKeeper.Models.Database;

public class StatisticEntry
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public DateTime Timestamp { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

<<<<<<< HEAD
    public virtual User? User { get; set; }
=======
    public virtual IdentityUser User { get; set; }
>>>>>>> 5671f99f3ae91b509feee3f29c2b15d2072e6e49
}