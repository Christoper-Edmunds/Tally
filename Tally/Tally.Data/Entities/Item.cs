using Microsoft.EntityFrameworkCore;

namespace Tally.Data.Entities
{
    [Index(nameof(Barcode))]
    public class Item : BaseEntity
    {
        // Foreign key
        public int ContainerId { get; set; }
        // Navigation property
        public Container Container { get; set; }
        public string? Barcode { get; set; }
        public int? CommonCatagoryId { get; set; }
        public CommonCatagory? CommonCatagory { get; set; }
        // Additional properties specific to Item
        public int? CustomCatagoryId { get; set; }
        public CustomCatagory? CustomCatagory { get; set; }
        public bool HasBeenOpened => OpenedDate.HasValue;
        public DateTime? OpenedDate { get; set; }


        // FoodDatase navigation properties
        public string? FoodDatabaseCode { get; set; }  // Nullable FK
        public FoodDatabaseSlowSearch? FoodDatabaseEntry { get; set; }  // Navigation property



    }
}
