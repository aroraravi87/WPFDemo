using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfAppDemo.Common
{
    public class WaterMarkHelpers : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] is bool && values[1] is bool)
            {
                bool hasText = !(bool)values[0];
                bool hasPassword = !(bool)values[0];
                bool hasFocus = (bool)values[1];
                if (hasFocus || hasText)
                { return Visibility.Collapsed; }
            }
            if (values.Length == 3 && values[2] is bool)
            {
                bool hasMouseDown = (bool)values[2];
                if (hasMouseDown)
                { return Visibility.Collapsed; }
            }

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
