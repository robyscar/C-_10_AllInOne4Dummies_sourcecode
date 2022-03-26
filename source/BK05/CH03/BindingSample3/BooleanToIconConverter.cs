using System;
using System.Globalization;
using System.Windows.Data;

namespace BindingSample3
{
    public class BooleanToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return value;
            }

            if ((bool)value == true)
            {
                return new GreenCheck();
            }
            else
            {
                return new RedX();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
