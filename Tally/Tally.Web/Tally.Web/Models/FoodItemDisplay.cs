namespace Tally.Web.Models;

/// <summary>
/// View model for the food expiry table.
/// The API maps Item (+ BaseEntity.CreatedDate) into this shape.
/// </summary>
public class FoodItemDisplay
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ShelfLifeDays { get; set; }
    public DateTime? OpenedDate { get; set; }
}
