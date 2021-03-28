namespace Core
{
    /// <summary>
    /// Класс <see cref="FileItem"/> хранит данные о файле
    /// </summary>
    public class FileItem
    {
        /// <summary>
        /// Возвращает и задает имя файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="FileItem"/>
        /// </summary>
        public FileItem()
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="FileItem"/>
        /// </summary>
        /// <param name="name"></param>
        public FileItem(string name)
        {
            Name = name;
        }
    }
}
