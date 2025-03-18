using System.Globalization;

namespace AdventureWorks.Converters;

public class StringToDoubleConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (double.TryParse(value?.ToString(), out double result))
            return result;

        return 0;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => value?.ToString();

}
