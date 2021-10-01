using System;
using System.Globalization;
using System.Windows.Data;

namespace StartApp.Converters
{
    class GreaterThanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }
            if (System.Convert.ToInt32(value) >= System.Convert.ToInt32(parameter))
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
