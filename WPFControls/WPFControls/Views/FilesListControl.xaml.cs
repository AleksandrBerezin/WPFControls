using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFControls.ViewModels;

namespace WPFControls.Views
{
    /// <summary>
    /// Interaction logic for FilesListControl.xaml
    /// </summary>
    public partial class FilesListControl : UserControl
    {
        /// <summary>
        /// Свойство зависимости списка контролов
        /// </summary>
        public static readonly DependencyProperty FileControlsProperty = 
            DependencyProperty.Register(nameof(FileControls),
                typeof(ObservableCollection<FileControl>),
                typeof(FilesListControl));

        /// <summary>
        /// Возвращает и задает список контролов
        /// </summary>
        public ObservableCollection<FileControl> FileControls
        {
            get => (ObservableCollection<FileControl>) GetValue(FileControlsProperty);
            set => SetValue(FileControlsProperty, value);
        }

        /// <summary>
        /// Создает экземпляр <see cref="FilesListControl"/>
        /// </summary>
        public FilesListControl()
        {
            InitializeComponent();

            FileControls = new ObservableCollection<FileControl>
            {
                new FileControl() {FileName = "Launcher.exe"},
                new FileControl() {FileName = "Launcher.Core.dll"},
                new FileControl() {FileName = "Launcher.pdb"}
            };
        }
    }
}
