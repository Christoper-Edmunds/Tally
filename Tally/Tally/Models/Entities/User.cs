using Microsoft.AspNetCore.Identity;

namespace Tally.Core.Models.Entities
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public bool IsActive { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
        public string? Role { get; set; } 
        // Navigation properties can be added here if needed
    }
}