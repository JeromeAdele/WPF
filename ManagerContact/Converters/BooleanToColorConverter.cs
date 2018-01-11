using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ManagerContact.Converters
{
    public class BooleanToColorConverter : IValueConverter
    {
        /// <summary>
        /// Conversion pour genre
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush bru = new SolidColorBrush(Colors.White);
            if (value != null && value is bool?)
            {
                bool? bol = value as bool?;
                if (bol.HasValue && bol.Value == true)
                {
                    bru = new SolidColorBrush(Colors.LightCyan);
                }
                else
                {
                    bru = new SolidColorBrush(Colors.LightPink);
                }
            }
            return bru;
        }

        /// <summary>
        /// Inversion des Genre
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("Méthode non implémentée !");
        }
    }
}