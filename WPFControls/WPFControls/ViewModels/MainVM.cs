using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPFControls.Services;
using WPFControls.Views;

namespace WPFControls.ViewModels
{
    /// <summary>
    /// Модель-представление окна <see cref="MainWindow"/>
    /// </summary>
    public class MainVM : ViewModelBase
    {
        /// <summary>
        /// Команда добавления файла
        /// </summary>
        private RelayCommand _addFileCommand;

        /// <summary>
        /// Команда удаления файла
        /// </summary>
        private RelayCommand<int> _removeFileCommand;

        /// <summary>
        /// Возвращает и задает список файлов
        /// </summary>
        public ObservableCollection<string> FilesList { get; set; } = new ObservableCollection<string>();

        /// <summary>
        /// Возвращает и задает команду добавления файла
        /// </summary>
        public RelayCommand AddFileCommand
        {
            get
            {
                return _addFileCommand ??
                       (_addFileCommand = new RelayCommand(() =>
                       {
                           var fileService = new FileService();
                           var result = fileService.ShowDialog(out string fileName);

                           if (result != true)
                           {
                               return;
                           }

                           FilesList.Add(fileName);
                       }));
            }
        }

        /// <summary>
        /// Возвращает и задает команду удаления файла
        /// </summary>
        public RelayCommand<int> RemoveFileCommand
        {
            get
            {
                return _removeFileCommand ??
                       (_removeFileCommand = new RelayCommand<int>((index) =>
                       {
                           FilesList.RemoveAt(index);
                       }));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
        }
    }
}
