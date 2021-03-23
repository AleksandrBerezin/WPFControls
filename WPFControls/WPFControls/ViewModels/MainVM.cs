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
        private RelayCommand _addCommand;

        /// <summary>
        /// Возвращает и задает команду добавления файла
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                       (_addCommand = new RelayCommand(() =>
                       {
                           // TODO Вызрать серфис, получить файл; Создать vm, добавить контрол
                           var fileService = new FileService();
                           var result = fileService.ShowDialog(out string fileName);

                           if (result != true)
                           {
                               return;
                           }

                           var vm = new FilesListVM();
                           // TODO В Vm создать свойство, связать его с FilesListControl
                       }));
            }
        }
    }
}
