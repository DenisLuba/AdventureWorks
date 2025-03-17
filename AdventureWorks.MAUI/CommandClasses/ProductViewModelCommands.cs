using AdventureWorks.EntityLayer;
using AdventureWorks.ViewModelLayer;
using Common.Library;

namespace AdventureWorks.MAUI.CommandClasses;

public class ProductViewModelCommands : ProductViewModel
{
    #region Constructors
    public ProductViewModelCommands() : base()
    {
    }

    public ProductViewModelCommands(IRepository<Product> repository) : base(repository)
    {
    } 
    #endregion
}
