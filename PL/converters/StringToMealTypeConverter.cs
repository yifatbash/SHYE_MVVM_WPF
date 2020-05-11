using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PL.converters
{
    class StringToMealTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string mealType = (string)value;
            switch (mealType)
            {
                case "Breakfast":
                    return 0;
                case "Lunch":
                    return 1;
                case "Dinner":
                    return 2;
                case "Snacks":
                    return 3;
                default:
                    return -1;
            }

        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string mealType = (string)value;
            switch (mealType)
            {
                case "Breakfast":
                    return 0;
                case "Lunch":
                    return 1;
                case "Dinner":
                    return 2;
                case "Snacks":
                    return 3;
                default:
                    return -1;
            }
        }
    }

}
