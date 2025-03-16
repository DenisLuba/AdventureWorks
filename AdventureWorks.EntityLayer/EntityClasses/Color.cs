using Common.Library;

namespace AdventureWorks.EntityLayer;

public class Color : EntityBase
{
    #region Private Variables
    private int _ColorId;
    private string? _ColorName;
    #endregion

    #region Public Properties
    public int ColorId
	{
		get => _ColorId; 
		set 
		{
			if (_ColorId != value)
			{
				_ColorId = value;
				RaisePropertyChanged(nameof(ColorId));
			}
		}
	}

	public string? ColorName
	{
		get => _ColorName;
		set
		{
			if (_ColorName != value)
			{
				_ColorName = value;
				RaisePropertyChanged(nameof(ColorName));
			}
		}
	}
    #endregion
}
