using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AdventureWorks.DataLayer;

/// <summary>
/// This class creates some fake data for Products.
/// </summary>
public partial class ProductRepository : IRepository<Product>
{
    #region Get Method
    public ObservableCollection<Product> Get()
    {
        return new ObservableCollection<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "Sport-100 Helmet, Blue",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 2,
                Name = "AWC Logo Cap",
                Color = "Multi",
                StandardCost = 5,
                ListPrice = 8.99,
                SellStartDate = DateTime.ParseExact(s: "01.01.2016", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XXL"
            },
            new Product
            {
                ProductId = 3,
                Name = "Sport-100 Helmet, Blue",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 4,
                Name = "Long-Sleeve Logo Jersey, S",
                Color = "Multi",
                StandardCost = 30,
                ListPrice = 49.99,
                SellStartDate = DateTime.ParseExact(s: "12.09.2017", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "S"
            },
            new Product
            {
                ProductId = 5,
                Name = "Product 5",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 6,
                Name = "Product 6",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 7,
                Name = "Product 7",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 8,
                Name = "Product 8",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 9,
                Name = "Product 9",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 10,
                Name = "Product 10",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
            new Product
            {
                ProductId = 11,
                Name = "Product 11",
                Color = "Blue",
                StandardCost = 22.9,
                ListPrice = 34.99,
                SellStartDate = DateTime.ParseExact(s: "15.05.2015", format: "dd.MM.yyyy", provider: CultureInfo.InvariantCulture),
                Size = "XL"
            },
        };
    }
    #endregion

    #region Get(id) Method
    public Product? Get(int id) => (from product in Get() where product.ProductId == id select product).FirstOrDefault();
    #endregion
}
