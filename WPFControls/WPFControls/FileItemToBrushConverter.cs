using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Core;

namespace WPFControls
{
    /// <summary>
    /// Класс <see cref="FileItemToBrushConverter"/> конвертирует <see cref="FileItem"/> в <see cref="SolidColorBrush"/>
    /// </summary>
    public class FileItemToBrushConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((FileItem) value).IsValidName
                ? new SolidColorBrush(Colors.White)
                : new SolidColorBrush(Color.FromRgb(255, 238, 238));
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}