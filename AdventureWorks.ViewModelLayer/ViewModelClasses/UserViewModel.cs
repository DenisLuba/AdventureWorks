using Common.Library;
using AdventureWorks.EntityLayer;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AdventureWorks.ViewModelLayer;

public class UserViewModel : ViewModelBase
{
    #region Constructors
    public UserViewModel() : base()
    {
    }

    public UserViewModel(IRepository<User>? repository) : base()
    {
        Repository = repository;
    }

    public UserViewModel(IRepository<User>? userRepository, IRepository<PhoneType>? phoneRepository)
    {
        Repository = userRepository;
        _PhoneTypeRepository = phoneRepository;
    }
    #endregion

    #region Private Variables
    private User? _UserObject = new();
    private ObservableCollection<User> _UserList = new();
    private ObservableCollection<string> _PhoneTypesList = [];
    private readonly IRepository<User>? Repository;
    private readonly IRepository<PhoneType>? _PhoneTypeRepository;
    #endregion

    #region Public Properties
    public User? UserObject
    {
        get => _UserObject;
        set
        {
            if (_UserObject != value)
            {
                _UserObject = value;
                RaisePropertyChanged(nameof(UserObject));
            }
        }
    }

    public ObservableCollection<User> UserList
    {
        get => _UserList;
        set
        {
            if (_UserList != value)
            {
                _UserList = value;
                RaisePropertyChanged(nameof(UserList));
            }
        }
    }

    public ObservableCollection<string> PhoneTypesList
    {
        get => _PhoneTypesList;
        set
        {
            if (_PhoneTypesList != value)
            {
                _PhoneTypesList = value;
                RaisePropertyChanged(nameof(PhoneTypesList));
            }
        }
    }
    #endregion

    #region Get Method
    /// <summary>
    /// Get a collection of the user objects.
    /// </summary>
    /// <returns>An Observable Collection of user objects.</returns>
    public ObservableCollection<User> Get()
    {
        if (Repository is not null)
        {
            UserList = new ObservableCollection<User>(Repository.Get());
        }

        return UserList;
    }
    #endregion

    #region Get(id) Method
    /// <summary>
    /// Get a single user object        
    /// </summary>
    /// <param name="id">The UserId to locate</param>
    /// <returns>An instance of a User object</returns>
    public User? Get(int id)
    {
        try
        {
            // Get a User from a data store
            if (Repository is not null)
            {
                UserObject = Repository.Get(id);
            }
            else
            {
                // MOCK Data
                UserObject = new User
                {
                    UserId = id,
                    LoginId = "SallyJones615",
                    FirstName = "Sally",
                    LastName = "Jones",
                    Email = "Sally@jones.com",
                    Phone = "615.987.3456",
                    PhoneType = new PhoneType { TypeDescription = "Mobile" },
                    IsFullTime = true,
                    IsEnrolledIn401k = true,
                    IsEnrolledInFlexTime = false,
                    IsEnrolledInHealthCare = true,
                    IsEnrolledInHSA = false,
                    IsActive = true,
                    // BirthDate = Convert.ToDateTime("12-08-1989"), // 12 августа для RU, но для US будет 8 декабря, поэтому можно использовать:
                    BirthDate = DateTime.ParseExact(s: "12-08-1989", format: "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    // где InvariantCulture - нейтральная культура, не зависящая от региональных настроек системы
                    StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
                };
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        return UserObject;
    }
    #endregion

    #region GetPhoneTypes Method
    public ObservableCollection<string> GetPhoneTypes()
    {
        if (_PhoneTypesList is not null)
        {
            var list = _PhoneTypeRepository?.Get() ?? [];

            PhoneTypesList = new ObservableCollection<string>(list.Select(row => row.TypeDescription ?? string.Empty));
        }

        return PhoneTypesList;
    }
    #endregion

    #region Save Method
    public virtual bool Save()
    {
        // TODO: Write code to save data
        System.Diagnostics.Debugger.Break();

        return true;
    }
    #endregion
}
