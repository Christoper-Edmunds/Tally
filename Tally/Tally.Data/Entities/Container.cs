namespace Tally.Data.Entities
{
    public class Container : BaseEntity
    {
        // Foreign key
        public int LocationId { get; set; }
        // Navigation property
        public Location? Location { get; set; }
        // Foreign key for Common Category
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
