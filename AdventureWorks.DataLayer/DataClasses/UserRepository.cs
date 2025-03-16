using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AdventureWorks.DataLayer;

/// <summary>
/// This class creates some fake data for the Users.
/// </summary>
public partial class UserRepository : IRepository<User>
{
    #region Get Method
    /// <summary>
    /// Get all User objects.
    /// </summary>
    /// <returns>A list of User objects.</returns>
    public ObservableCollection<User> Get()
    {
        return new ObservableCollection<User>
        {
            new User
            {
                UserId = 1,
                LoginId = "PaulShaefer1",
                FirstName = "Paul",
                LastName = "Shaefer",
                Email = "Pauls@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "(615) 399-9212",
                PhoneType = new PhoneType { TypeDescription = "Mobile" },
                IsEnrolledIn401k = true,
                IsFullTime = true,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = true,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "3/5/1963", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 2,
                LoginId = "MichaelKawoski2",
                FirstName = "Michael",
                LastName = "Kawoski",
                Email = "Michael@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "714.939.0002",
                PhoneType = new PhoneType { TypeDescription = "Home" },
                IsEnrolledIn401k = true,
                IsFullTime = true,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = true,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "10/12/1978", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 3,
                LoginId = "SaraWinchell3",
                FirstName = "Sara",
                LastName = "Winchell",
                Email = "Sara@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "(714) 738-9382",
                PhoneType = new PhoneType { TypeDescription = "Home" },
                IsEnrolledIn401k = true,
                IsFullTime = false,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "30/12/1989", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 4,
                LoginId = "JohnKroon4",
                FirstName = "John",
                LastName = "Kroon",
                Email = "John@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "949.667.7347",
                PhoneType = new PhoneType { TypeDescription = "Mobile" },
                IsEnrolledIn401k = true,
                IsFullTime = true,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "15/05/1987", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 5,
                LoginId = "TimNicker5",
                FirstName = "Tim",
                LastName = "Nicker",
                Email = "Tim@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "(714) 767-3747",
                PhoneType = new PhoneType { TypeDescription = "Mobile" },
                IsEnrolledIn401k = true,
                IsFullTime = true,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "24/10/1989", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 6,
                LoginId = "RussMartlog6",
                FirstName = "Russ",
                LastName = "Martlog",
                Email = "Russ@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "714-334-5643",
                PhoneType = new PhoneType { TypeDescription = "Mobile" },
                IsEnrolledIn401k = true,
                IsFullTime = false,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "14/1/1969", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 7,
                LoginId = "JohnBoron7",
                FirstName = "John",
                LastName = "Boron",
                Email = "John@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "(714) 939-9993",
                PhoneType = new PhoneType { TypeDescription = "Home" },
                IsEnrolledIn401k = true,
                IsFullTime = false,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "15/1/1977", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            },
            new User
            {
                UserId = 8,
                LoginId = "JetaBoron8",
                FirstName = "Jeta",
                LastName = "Boron",
                Email = "Jeta@paulsautoparts.com",
                Password = "P@sswOrd",
                Phone = "(714) 939-9993",
                PhoneType = new PhoneType { TypeDescription = "Home" },
                IsEnrolledIn401k = true,
                IsFullTime = false,
                IsEnrolledInFlexTime = true,
                IsEnrolledInHealthCare = true,
                IsEnrolledInHSA = false,
                IsActive = true,
                BirthDate = DateTime.ParseExact(s: "1/11/1979", format: "d/M/yyyy", provider: CultureInfo.InvariantCulture),
                StartTime = new TimeSpan(hours: 7, minutes: 30, seconds: 0)
            }
        };
    }
    #endregion

    #region Get(id) Method
    /// <summary>
    /// Get a single User object.
    /// </summary>
    /// <param name="id">The value to locate.</param>
    /// <returns>A valid User object, or null if not found.</returns>
    public User? Get(int id)
    {
        return Get().Where(row => row.UserId == id).FirstOrDefault();
    }
    #endregion
}
