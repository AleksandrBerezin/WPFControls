using System.IO;
using Microsoft.Win32;

namespace WPFControls.Services
{
    /// <summary>
    /// Класс <see cref="FileService"/> для открытия окна выбора файлов
    /// </summary>
    public class FileService : IFileService
    {
        /// <inheritdoc/>
        public bool? ShowDialog(out string fileName)
        {
            fileName = null;
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                fileName = Path.GetFileName(dialog.FileName);
                return true;
            }

            return false;
        }
    }
}