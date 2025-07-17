namespace Tally.Core.Models.Entities
{
    public class Item : BaseEntity
    {
        // Foreign key
        public int RoomId { get; set; }
        // Navigation property
        public Room? Room { get; set; }
        // Additional properties specific to Item
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
