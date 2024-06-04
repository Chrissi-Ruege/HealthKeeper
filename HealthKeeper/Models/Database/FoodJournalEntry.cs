using Microsoft.AspNetCore.Identity;

namespace HealthKeeper.Models.Database;

/// <summary>
/// Describes a entry in the food journal of a user.
/// All values ​​are given for 100 grams.
/// </summary>
public class FoodJournalEntry
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Name { get; set; }

    public float Calories { get; set; }

    public float Fat { get; set; }

    public float Protein { get; set; }

    public float Sugar { get; set; }

    public float Carbs { get; set; }

    public virtual IdentityUser? User { get; set; }
}