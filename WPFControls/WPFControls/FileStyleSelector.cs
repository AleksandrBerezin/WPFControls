using System.Windows;
using System.Windows.Controls;
using Core;

namespace WPFControls
{
    /// <summary>
    /// Селектор стиля <see cref="FileStyleSelector"/> для элемента списка файлов
    /// </summary>
    public class FileStyleSelector : StyleSelector
    {
        /// <summary>
        /// Стиль для расширения файлов .exe или .dll
        /// </summary>
        public Style CorrectExtensionStyle { get; set; }

        /// <summary>
        /// Стиль для всех расширений файлов, кроме .exe или .dll
        /// </summary>
        public Style IncorrectExtensionStyle { get; set; }

        /// <inheritdoc/>
        public override Style SelectStyle(object item, DependencyObject container)
        {
            var file = (FileItem) item;
            return file.IsValidName ? CorrectExtensionStyle : IncorrectExtensionStyle;
        }
    }
}