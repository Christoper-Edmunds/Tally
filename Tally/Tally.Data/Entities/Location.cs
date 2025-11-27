namespace Tally.Data.Entities
{
    public class Location : BaseEntity
    {

        // Foreign key
        public int UserId { get; set; }
        public string? Address { get; set; } = string.Empty;
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
