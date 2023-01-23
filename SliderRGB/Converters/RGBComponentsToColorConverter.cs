using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SliderRGB.Converters
{
    internal class RGBComponentsToColorConverter : IMultiValueConverter
    {
        // z kodu do widoku
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length != 3)
                return Binding.DoNothing;

            byte red = System.Convert.ToByte((double)values[0]);
            byte green = System.Convert.ToByte((double)values[1]);
            byte blue = System.Convert.ToByte((double)values[2]);

            Color color = Color.FromRgb(red, green, blue);
            return new SolidColorBrush(color);
        }

        // z widoku do kodu
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
