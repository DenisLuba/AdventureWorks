using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

namespace AdventureWorks.ViewModelLayer;

public class ProductViewModel : ViewModelBase
{
    #region Constructors
    public ProductViewModel() : base()
    {
    }

    public ProductViewModel(IRepository<Product> repository) : base()
    {
        Repository = repository;
    }
    #endregion

    #region Private Variables
    private IRepository<Product>? Repository;
    private ObservableCollection<Product> _ProductList = [];
    private Product? _ProductObject = new();
    #endregion

    #region Public Properties
    public Product? ProductObject
    {
        get => _ProductObject;
        set
        {
            if (_ProductObject != value)
            {
                _ProductObject = value;
                RaisePropertyChanged(nameof(ProductObject));
            }
        }
    } 

    public ObservableCollection<Product> ProductList
    {
        get => _ProductList;
        set
        {
            if (_ProductList != value)
            {
                _ProductList = value;
                RaisePropertyChanged(nameof(ProductList));
            }
        }
    }
    #endregion

    #region Get Method
    /// <summary>
    /// Get a Collection of product objects.
    /// </summary>
    /// <returns>An Observable Collection of product objects.</returns>
    public ObservableCollection<Product> Get()
    {
        if (Repository is not null) ProductList = new(Repository.Get());

        return ProductList;
    }
    #endregion

    #region Get(id) Method
    /// <summary>
    /// Get a single Product object.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>An instance of a Product object.</returns>
    public Product? Get(int id)
    {
        try
        {
            if (Repository is not null)
            {
                // Get a Product from a data store
                ProductObject = Repository.Get(id);
            }
            else
            {
                // MOCK Data
                ProductObject = new()
                {
                    ProductId = id,
                    Name = "A New Product",
                    Color = "Black",
                    StandardCost = 10,
                    ListPrice = 20,
                    SellStartDate = Convert.ToDateTime("7/1/2023"),
                    Size = "LG"
                };
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        return ProductObject;
    }
    #endregion

    #region Save Method
    public bool Save()
    {
        throw new NotImplementedException();
    } 
    #endregion
}
