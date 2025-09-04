namespace Tally.Data.Models.Entities
{
    public class Room : BaseEntity
    {
        // Foreign key
        public int LocationId { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
