using AdventureWorks.ViewModelLayer;
using AdventureWorks.EntityLayer;
using System.Windows.Input;
using Common.Library;

namespace AdventureWorks.MAUI.CommandClasses;

public class UserViewModelCommands : UserViewModel
{
    #region Constructors
    public UserViewModelCommands() : base()
    {
    }

    public UserViewModelCommands(IRepository<User> repository) : base(repository)
    {
    }

    public UserViewModelCommands(IRepository<User>? userRepository, IRepository<PhoneType>? phoneRepository) : base(userRepository, phoneRepository)
    {
    }
    #endregion

    #region Private Variables
    private bool _IsSaveCommandEnabled = true;
    #endregion

    #region Public Properties  
    public bool IsSaveCommandEnabled
    {
        get => _IsSaveCommandEnabled;
        set
        {
            if (_IsSaveCommandEnabled != value)
            {
                _IsSaveCommandEnabled = value;
                RaisePropertyChanged(nameof(IsSaveCommandEnabled));
            }
        }
    } 
    #endregion

    #region Commands
    public ICommand? SaveCommand { get; private set; }
    public ICommand? EditCommand { get; private set; }
    #endregion

    #region Init Method
    public override void Init()
    {
        base.Init();

        // Create commands for this view
        SaveCommand = new Command(execute: async () => await SaveAsync(), canExecute: () => IsSaveCommandEnabled);
        EditCommand = new Command<int>(execute: async (int id) => await EditAsync(id), (id) => true);
    }
    #endregion

    #region EditAsync Method
    protected async Task EditAsync(int id)
    {
        await Shell.Current.GoToAsync($"{nameof(Views.UserDetailView)}?id={id}");
    }
    #endregion

    #region SaveAsync Method
    public async Task<bool> SaveAsync()
    {
        var ret = base.Save();

        if (ret) await Shell.Current.GoToAsync("..");

        return ret;
    } 
    #endregion
}
