using System.Collections.Generic;
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
        /// Сервис для открытия файла
        /// </summary>
        private IFileService _fileService;

        /// <summary>
        /// Возвращает и задает список файлов
        /// </summary>
        public ObservableCollection<FileItem> FilesList { get; set; } = new ObservableCollection<FileItem>();

        //TODO: сделай добавление множества файлов вместо добавления по одному (DONE)
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
                           var result = _fileService.ShowDialog(out List<string> fileNames);

                           if (result != true)
                           {
                               return;
                           }

                           foreach (var fileName in fileNames)
                           {
                               FilesList.Add(new FileItem(fileName));
                           }
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
        public MainVM(IFileService fileService)
        {
            _fileService = fileService;
        }
    }
}
