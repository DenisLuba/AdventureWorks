using Common.Library;

namespace AdventureWorks.EntityLayer;

public class Product : EntityBase
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public double StandardCost { get; set; }
    public double ListPrice { get; set; }
    public DateTime? SellStartDate { get; set; }
    public string? Size;
}
