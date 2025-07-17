namespace Tally.Core.Models
{
    public class UserDto
    {
        public required int Id { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Role { get; set; }

    }
}
