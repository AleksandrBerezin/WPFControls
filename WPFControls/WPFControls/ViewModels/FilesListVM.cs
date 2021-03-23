using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using WPFControls.Views;

namespace WPFControls.ViewModels
{
    /// <summary>
    /// Модель-представление контрола <see cref="FilesListControl"/>
    /// </summary>
    public class FilesListVM : ViewModelBase
    {
        /// <summary>
        /// Список файлов
        /// </summary>
        private ObservableCollection<string> _filesList;

        /// <summary>
        /// Возвращает и задает список файлов
        /// </summary>
        public ObservableCollection<string> FilesList { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="FilesListVM"/>
        /// </summary>
        public FilesListVM()
        {
        }
    }
}
