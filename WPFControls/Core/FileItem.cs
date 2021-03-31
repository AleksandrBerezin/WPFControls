using System.IO;

namespace Core
{
    /// <summary>
    /// Класс <see cref="FileItem"/> хранит данные о файле
    /// </summary>
    public class FileItem
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        private string _name;

        /// <summary>
        /// Возвращает и задает имя файла
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                var extension = Path.GetExtension(_name);
                IsValidName = extension == ".exe" || extension == ".dll";
            }
        }

        /// <summary>
        /// Возрращает true, если файл имеет расширение *.exe или *.dll
        /// </summary>
        public bool IsValidName = true;

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
