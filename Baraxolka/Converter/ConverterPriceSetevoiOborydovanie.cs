using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Baraxolka.Converter
{
    public class ConverterPriceSetevoiOborydovanie : IValueConverter
    {
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              CultureInfo culture)
        {
            int price = int.Parse(value.ToString());
            if (price <= 1000)
                return new Uri(Path.Combine(Environment.CurrentDirectory, "deshman3.png"), UriKind.Absolute);
            else
                return new Uri(Path.Combine(Environment.CurrentDirectory, "dorogo3.jpg"), UriKind.Absolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
