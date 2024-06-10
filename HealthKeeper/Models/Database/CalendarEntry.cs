using Microsoft.AspNetCore.Identity;

namespace HealthKeeper.Models.Database
{
    public class CalendarEntry
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public virtual required IdentityUser User { get; set; }
    }
}
