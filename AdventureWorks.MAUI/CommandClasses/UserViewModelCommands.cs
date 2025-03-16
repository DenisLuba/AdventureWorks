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
    #endregion

    #region Init Method
    public override void Init()
    {
        base.Init();

        // Create commands for this view
        SaveCommand = new Command(execute: () => Save(), canExecute: () => IsSaveCommandEnabled);
    }
    #endregion
}
