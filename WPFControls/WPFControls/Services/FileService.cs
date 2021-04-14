using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace WPFControls.Services
{
    /// <summary>
    /// Класс <see cref="FileService"/> для открытия окна выбора файлов
    /// </summary>
    public class FileService : IFileService
    {
        /// <inheritdoc/>
        public bool? ShowDialog(out List<string> fileNames)
        {
            fileNames = new List<string>();
            var dialog = new OpenFileDialog {Multiselect = true};

            if (dialog.ShowDialog() == true)
            {
                var files = dialog.FileNames;
                fileNames.AddRange(files.Select(Path.GetFileName));
                return true;
            }

            return false;
        }
    }
}