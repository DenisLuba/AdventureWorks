using Common.Library;

namespace AdventureWorks.EntityLayer;

public class Product : EntityBase
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? ProductNumber { get; set; }
    public string? Color { get; set; }
    public double StandardCost { get; set; }
    public double ListPrice { get; set; }
    public double Weight { get; set; }
    public string? Category { get; set; }
    public string? Model { get; set; }
    public DateTime? SellStartDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public DateTime? DiscountinuedDate { get; set; }
    public string? Size { get; set; }
}
