namespace Tally.Data.Entities
{
    public class Room : BaseEntity
    {
        // Foreign key
        public int LocationId { get; set; }
        // Navigation property
        public Location Location { get; set; } = null!;
        public ICollection<Container> Containers { get; set; } = new List<Container>();
    }
}
