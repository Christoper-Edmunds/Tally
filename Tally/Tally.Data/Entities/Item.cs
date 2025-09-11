namespace Tally.Data.Entities
{
    public class Item : BaseEntity
    {
        // Foreign key
        public int ContainerId { get; set; }
        // Navigation property
        public Container Container { get; set; }
        public int? CommonCatagoryId { get; set; }
        public CommonCatagory? CommonCatagory { get; set; }
        // Additional properties specific to Item
        public int CustomCatagoryId { get; set; }
        public CustomCatagory? CustomCatagory { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime? OpenedDate { get; set; }
        public bool HasBeenOpened => OpenedDate.HasValue;
        public ICollection<User> Users { get; set; } = new List<User>();

        public Item()
        {
            CreatedDate = DateTime.UtcNow;
            IsActive = true;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
