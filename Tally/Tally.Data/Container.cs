namespace Tally.Data.Models.Entities
{
    public class Container : BaseEntity
    {
        // Foreign key
        public int LocationId { get; set; }
        // Navigation property
        public Location? Location { get; set; }
        // Foreign key for Common Category
        public Item? Item { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
