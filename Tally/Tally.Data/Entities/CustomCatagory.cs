namespace Tally.Data.Entities
{
    public class CustomCatagory : CommonCatagory
    {
        public ICollection<Item> CustomCatagoryItems { get; set; }
    }
}
