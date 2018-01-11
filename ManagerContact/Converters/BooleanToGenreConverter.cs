using System;
using System.Globalization;
using System.Windows.Data;

namespace ManagerContact.Converters
{
    public class BooleanToGenreConverter : IValueConverter
    {/// <summary>
     /// Méthode de Conversion d'un boolean en chaine de caractère
     /// </summary>
     /// <param name="value"></param>
     /// <param name="targetType"></param>
     /// <param name="parameter"></param>
     /// <param name="culture"></param>
     /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string genre = null;
            if (value != null && value is bool?)
            {
                bool? bol = value as bool?;
                if (bol.HasValue && bol.Value == true)
                {
                    genre = "Masculin";
                }
                else
                {
                    genre = "Feminin";
                }
            }
            return genre;
        }

        /// <summary>
        ///Méthode d'inversion de la conversion précédente.
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