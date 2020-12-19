using System;
using System.Globalization;
using System.Windows.Data;

namespace FileManager.UI.Converters
{
    public class ValueToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * 0.01 * 360;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * 100 / 360;
        }
    }
}
