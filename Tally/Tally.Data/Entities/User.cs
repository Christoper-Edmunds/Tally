using Microsoft.AspNetCore.Identity;

namespace Tally.Data.Entities
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public bool IsActive { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<Container> Containers { get; set; } = new List<Container>();
        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
