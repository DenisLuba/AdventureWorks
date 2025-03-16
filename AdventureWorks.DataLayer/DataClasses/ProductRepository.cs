using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer;

/// <summary>
/// This class creates some fake data for Products.
/// </summary>
public partial class ProductRepository : IRepository<Product>
{
    #region Get Method
    public ObservableCollection<Product> Get()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Get(id) Method
    public Product? Get(int id)
    {
        throw new NotImplementedException();
    }
    #endregion
}
