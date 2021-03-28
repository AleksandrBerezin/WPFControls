using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Core;
using GalaSoft.MvvmLight.Command;

namespace WPFControls.Views
{
    /// <summary>
    /// Interaction logic for FilesListControl.xaml
    /// </summary>
    public partial class FilesListControl : UserControl
    {
        /// <summary>
        /// Свойство зависимости коллекции файлов
        /// </summary>
        public static readonly DependencyProperty FilesCollectionProperty = 
            DependencyProperty.Register(nameof(FilesCollection),
                typeof(ObservableCollection<FileItem>),
                typeof(FilesListControl));

        /// <summary>
        /// Возвращает и задает команду удаления файла по индексу
        /// </summary>
        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register(nameof(RemoveCommand),
                typeof(RelayCommand<FileItem>),
                typeof(FilesListControl));

        /// <summary>
        /// Возвращает и задает коллекцию файлов
        /// </summary>
        public ObservableCollection<FileItem> FilesCollection
        {
            get => (ObservableCollection<FileItem>) GetValue(FilesCollectionProperty);
            set => SetValue(FilesCollectionProperty, value);
        }

        /// <summary>
        /// Команда удаления файла по индексу
        /// </summary>
        public RelayCommand<FileItem> RemoveCommand
        {
            get => (RelayCommand<FileItem>)GetValue(RemoveCommandProperty);
            set => SetValue(RemoveCommandProperty, value);
        }

        /// <summary>
        /// Создает экземпляр <see cref="FilesListControl"/>
        /// </summary>
        public FilesListControl()
        {
            InitializeComponent();
        }
    }
}
