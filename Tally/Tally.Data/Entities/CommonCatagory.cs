namespace Tally.Data.Entities
{
    public class CommonCatagory : BaseEntity
    {
        public string CategoryType { get; set; } = string.Empty;
        public TimeSpan ExpirationTimeWhenClosed { get; set; } = TimeSpan.Zero;
        public TimeSpan ExpirationTimeWhenOpen { get; set; } = TimeSpan.Zero;
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
