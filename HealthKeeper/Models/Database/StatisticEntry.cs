namespace HealthKeeper.Models.Database;

public class StatisticEntry
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Timestamp { get; set; }
    public float Weight { get; set; }
    public float Height { get; set; }

    public virtual User? User { get; set; }
}