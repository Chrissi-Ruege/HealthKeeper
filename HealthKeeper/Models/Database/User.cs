namespace HealthKeeper.Models.Database;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }

    public string? Password { get; set; }
    public string? Email { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public Gender Gender { get; set; }

    public virtual ICollection<StatisticEntry>? Statistics { get; set; }
}

public enum Gender
{
    Female,
    Male
}

