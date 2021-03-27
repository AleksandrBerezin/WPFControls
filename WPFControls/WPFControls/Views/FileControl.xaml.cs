using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;

namespace WPFControls.Views
{
    /// <summary>
    /// Interaction logic for FileControl.xaml
    /// </summary>
    public partial class FileControl : UserControl
    {
        /// <summary>
        /// Свойство зависимости имени файла
        /// </summary>
        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register(nameof(FileName),
            typeof(string), typeof(FileControl));

        ///// <summary>
        ///// Возвращает и задает команду удаления файла
        ///// </summary>
        //public static readonly DependencyProperty RemoveCommandProperty =
        //    DependencyProperty.Register(nameof(RemoveCommand),
        //        typeof(RelayCommand<object>),
        //        typeof(FilesListControl));

        /// <summary>
        /// Возвращает и задает имя файла
        /// </summary>
        public string FileName
        {
            get => (string) GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        ///// <summary>
        ///// Команда удаления файла
        ///// </summary>
        //public RelayCommand<object> RemoveCommand
        //{
        //    get => (RelayCommand<object>)GetValue(RemoveCommandProperty);
        //    set => SetValue(RemoveCommandProperty, value);
        //}

        /// <summary>
        /// Создает экземпляр <see cref="FileControl"/>
        /// </summary>
        public FileControl()
        {
            InitializeComponent();
        }
    }
}
