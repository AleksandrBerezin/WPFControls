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
        /// <param name="fileName"></param>
        /// <returns></returns>
        bool? ShowDialog(out string fileName);
    }
}