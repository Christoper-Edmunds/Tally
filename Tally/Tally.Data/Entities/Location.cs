namespace Tally.Data.Entities
{
    public class Location : BaseEntity
    {
        public string? Address { get; set; } = string.Empty;
        public ICollection<Container> Containers { get; set; } = new List<Container>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
