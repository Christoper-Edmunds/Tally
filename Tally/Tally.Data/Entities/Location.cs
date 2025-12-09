namespace Tally.Data.Entities
{
    public class Location : BaseEntity
    {
        public required User User { get; set; }
        // Foreign key
        public string? Address { get; set; } = string.Empty;
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
        public ICollection<User> Users { get; set; } = new List<User>();

    }
}
