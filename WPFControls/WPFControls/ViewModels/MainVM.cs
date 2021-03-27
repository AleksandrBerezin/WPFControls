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
        /// Возвращает и задает список файлов
        /// </summary>
        public ObservableCollection<string> FilesList { get; set; }

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
        /// Создает экземпляр <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            FilesList = new ObservableCollection<string>();
        }
    }
}
