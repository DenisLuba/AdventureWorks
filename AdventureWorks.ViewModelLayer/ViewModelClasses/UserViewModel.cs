using Common.Library;
using AdventureWorks.EntityLayer;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AdventureWorks.ViewModelLayer;

public class UserViewModel : ViewModelBase
{
    #region Private Variables
    private User? _UserObject = new();
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
    #endregion

    #region Get Method
    public ObservableCollection<User> Get()
    {
        return [];
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
            // TODO: Get a User from a data store

            // MOCK Data
            UserObject = new User
            {
                UserId = id,
                LoginId = "SallyJones615",
                FirstName = "Sally",
                LastName = "Jones",
                Email = "Sally@jones.com",
                Phone = "615.987.3456",
                PhoneType = "Mobile",
                IsFullTime= true,
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
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        return UserObject;
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
