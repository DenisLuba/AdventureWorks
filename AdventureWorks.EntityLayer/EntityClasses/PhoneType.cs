using Common.Library;

namespace AdventureWorks.EntityLayer;

public class PhoneType : EntityBase
{
    #region Private Variables
    private int _PhoneTypeId;
    private string? _TypeDescription;
    #endregion

    #region Public Properties
    public int PhoneTypeId
    {
        get => _PhoneTypeId;
        set
        {
            if (PhoneTypeId != value)
            {
                _PhoneTypeId = value;
                RaisePropertyChanged(nameof(PhoneTypeId));
            }
        }
    }

    public string? TypeDescription
    {
		get => _TypeDescription; 
		set
		{
			if (_TypeDescription != value)
			{
				_TypeDescription = value;
				RaisePropertyChanged(nameof(TypeDescription));
			}
		}
	}
	#endregion
}
