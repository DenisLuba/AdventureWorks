using AdventureWorks.EntityLayer;
using AdventureWorks.ViewModelLayer;
using Common.Library;
using System.Windows.Input;

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

    #region Init Method
    public override void Init()
    {
        base.Init();

        // Create commands for this view
        SaveCommand = new Command(async () => await SaveAsync(), () => IsSaveCommandEnabled);
        EditCommand = new Command<int>(async (int id) => await EditAsync(id), (id) => true);
    } 
    #endregion

    #region Commands
    public ICommand? SaveCommand { get; private set; }
    public ICommand? EditCommand { get; private set; }
    #endregion

    #region Private Variables
    private bool _IsSaveCommandEnable = true;
    #endregion

    #region Public Properties
    public bool IsSaveCommandEnabled
    {
        get => _IsSaveCommandEnable;
        set
        {
            if (_IsSaveCommandEnable != value)
            {
                _IsSaveCommandEnable = value;
                RaisePropertyChanged(nameof(IsSaveCommandEnabled));
            }
        }
    }
    #endregion

    #region SaveAsync Method
    protected async Task<bool> SaveAsync()
    {
        var ret = base.Save();

        if (ret) await Shell.Current.GoToAsync("..");

        return ret;
    } 
    #endregion

    #region EditAsync Method 
    protected async Task EditAsync(int id)
    {
        await Shell.Current.GoToAsync($"{nameof(Views.ProductDetailView)}?id={id}");
    } 
    #endregion
}
