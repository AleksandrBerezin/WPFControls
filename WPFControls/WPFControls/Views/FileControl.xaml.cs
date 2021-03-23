using System.Windows;
using System.Windows.Controls;

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
        
        /// <summary>
        /// Возвращает и задает имя файла
        /// </summary>
        public string FileName
        {
            get => (string) GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        /// <summary>
        /// Создает экземпляр <see cref="FileControl"/>
        /// </summary>
        public FileControl()
        {
            InitializeComponent();
        }
    }
}
