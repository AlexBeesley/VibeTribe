using Microsoft.AspNetCore.Identity;

namespace VibeTribe.Data
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public string? ProfileImageUrl { get; set; }
        public string? Bio { get; set; }
    }
}