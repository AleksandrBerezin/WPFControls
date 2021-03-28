using System.Collections.ObjectModel;
using Core;
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
        private RelayCommand<FileItem> _removeFileCommand;

        /// <summary>
        /// Возвращает и задает список файлов
        /// </summary>
        public ObservableCollection<FileItem> FilesList { get; set; } = new ObservableCollection<FileItem>();

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

                           FilesList.Add(new FileItem(fileName));
                       }));
            }
        }

        /// <summary>
        /// Возвращает и задает команду удаления файла
        /// </summary>
        public RelayCommand<FileItem> RemoveFileCommand
        {
            get
            {
                return _removeFileCommand ??
                       (_removeFileCommand = new RelayCommand<FileItem>(file =>
                       {
                           FilesList.Remove(file);
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
