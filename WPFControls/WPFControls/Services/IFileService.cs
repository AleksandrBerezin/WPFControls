using System.Collections.Generic;

namespace WPFControls.Services
{
    /// <summary>
    /// Интерфейс <see cref="IFileService"/> для открытия окна выбора файлов
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Открытие окна выбора файла
        /// </summary>
        /// <param name="fileNames"></param>
        /// <returns></returns>
        bool? ShowDialog(out List<string> fileNames);
    }
}