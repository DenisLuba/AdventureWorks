using Common.Library;

namespace AdventureWorks.EntityLayer;

public class User : EntityBase
{
    #region Private Variables
    private int _UserId;
    private string _LoginId = string.Empty;
    private string _FirstName = string.Empty;
    private string _LastName = string.Empty;
    private string _Email = string.Empty;
    private string _Password = string.Empty;
    private string _Phone = string.Empty;
    private PhoneType _PhoneType = new();
    private bool _IsFullTime;
    private bool _IsEnrolledIn401k;
    private bool _IsEnrolledInHealthCare;
    private bool _IsEnrolledInHSA;
    private bool _IsEnrolledInFlexTime;
    private bool _IsActive;
    private DateTime _BirthDate = new();
    private TimeSpan _StartTime = new(6, 0, 0);
    #endregion

    #region Public Properties
    public int UserId
    {
        get => _UserId;
        set
        {
            if (_UserId != value)
            {
                _UserId = value;
                RaisePropertyChanged(nameof(UserId));
            }
        }
    }

    public string LoginId
    {
        get { return _LoginId; }
        set
        {
            if (_LoginId != value)
            {
                _LoginId = value;
                RaisePropertyChanged(nameof(LoginId));
            }
        }
    }

    public string FirstName
    {
        get => _FirstName;
        set
        {
            if (_FirstName != value)
            {
                _FirstName = value;
                RaisePropertyChanged(nameof(FirstName));
            }
        }
    }

    public string FullName => $"{FirstName} {LastName}";

    public string LastNameFirstName => $"{LastName} {FirstName}";

    public string LastName
    {
        get => _LastName;
        set
        {
            _LastName = value;
            RaisePropertyChanged(nameof(LastName));
        }
    }

    public string Email
    {
        get => _Email;
        set
        {
            if (_Email != value)
            {
                _Email = value;
            }
            RaisePropertyChanged(nameof(Email));
        }

    }

    public string Password
    {
        get => _Password;
        set
        {
            if (_Password != value)
            {
                _Password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }
    }

    public string Phone
    {
        get => _Phone;
        set
        {
            if (_Phone != value)
            {
                _Phone = value;
                RaisePropertyChanged(nameof(Phone));
            }
        }
    }

    public PhoneType PhoneType
    {
        get => _PhoneType;
        set
        {
            if (_PhoneType != value)
            {
                _PhoneType = value;
                RaisePropertyChanged(nameof(PhoneType));
            }
        }
    }

    public bool IsFullTime
    {
        get => _IsFullTime;
        set
        {
            if (_IsFullTime != value)
            {
                _IsFullTime = value;
                RaisePropertyChanged(nameof(IsFullTime));
            }
        }
    }

    public bool IsEnrolledIn401k
    {
        get => _IsEnrolledIn401k;
        set
        {
            if (_IsEnrolledIn401k != value)
            {
                _IsEnrolledIn401k = value;
                RaisePropertyChanged(nameof(IsEnrolledIn401k));
            }
        }
    }

    public bool IsEnrolledInHealthCare
    {
        get => _IsEnrolledInHealthCare;
        set
        {
            if (_IsEnrolledInHealthCare != value)
            {
                _IsEnrolledInHealthCare = value;
                RaisePropertyChanged(nameof(IsEnrolledInHealthCare));
            }
        }
    }

    public bool IsEnrolledInHSA
    {
        get => _IsEnrolledInHSA;
        set
        {
            if (_IsEnrolledInHSA != value)
            {
                _IsEnrolledInHSA = value;
                RaisePropertyChanged(nameof(IsEnrolledInHSA));
            }
        }
    }

    public bool IsEnrolledInFlexTime
    {
        get => _IsEnrolledInFlexTime;
        set
        {
            if (_IsEnrolledInFlexTime != value)
            {
                _IsEnrolledInFlexTime = value;
                RaisePropertyChanged(nameof(IsEnrolledInFlexTime));
            }
        }
    }

    public bool IsActive
    {
        get => _IsActive;
        set
        {
            if (_IsActive != value)
            {
                _IsActive = value;
                RaisePropertyChanged(nameof(IsActive));
            }
        }
    }

    public DateTime BirthDate
    {
        get => _BirthDate;
        set
        {
            if (_BirthDate != value)
            {
                _BirthDate = value;
                RaisePropertyChanged(nameof(BirthDate));
            }
        }
    }

    public TimeSpan StartTime
    {
        get => _StartTime;
        set
        {
            if (_StartTime != value)
            {
                _StartTime = value;
                RaisePropertyChanged(nameof(StartTime));
            }
        }
    }
    #endregion
}