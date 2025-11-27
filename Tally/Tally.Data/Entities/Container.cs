namespace Tally.Data.Entities
{
    public class Container : BaseEntity
    {
        // Foreign key
        public int RoomId { get; set; }
        // Navigation property
        public Room? Room { get; set; }
        // Foreign key for Common Category
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
