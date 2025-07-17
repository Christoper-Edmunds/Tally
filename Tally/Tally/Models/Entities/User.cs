namespace Tally.Core.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public bool IsActive { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
        public string? Role { get; set; } 
        // Navigation properties can be added here if needed
    }
}