using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PL.converters
{
    class StringToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string Date = (string)value;
            return DateTime.Parse(Date);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime Date = (DateTime)value;
            return Date.ToString();

        }
    }

}
