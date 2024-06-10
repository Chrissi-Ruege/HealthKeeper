using Microsoft.AspNetCore.Identity;

namespace HealthKeeper.Models.Database
{
    public class CalendarEntry
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
