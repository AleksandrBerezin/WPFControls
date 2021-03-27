using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
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
        /// Свойство зависимости коллекции файлов
        /// </summary>
        public static readonly DependencyProperty FilesCollectionProperty = 
            DependencyProperty.Register(nameof(FilesCollection),
                typeof(ObservableCollection<string>),
                typeof(FilesListControl),
                new PropertyMetadata(new ObservableCollection<string>(),
                    new PropertyChangedCallback(FilesCollectionChanged)));

        ///// <summary>
        ///// Возвращает и задает команду добавления файла
        ///// </summary>
        //public static readonly DependencyProperty AddCommandProperty =
        //    DependencyProperty.Register(nameof(AddCommand),
        //        typeof(RelayCommand),
        //        typeof(FilesListControl));

        /// <summary>
        /// Возвращает и задает список контролов
        /// </summary>
        public ObservableCollection<FileControl> FileControls
        {
            get => (ObservableCollection<FileControl>) GetValue(FileControlsProperty);
            set => SetValue(FileControlsProperty, value);
        }

        /// <summary>
        /// Возвращает и задает коллекцию файлов
        /// </summary>
        public ObservableCollection<string> FilesCollection
        {
            get => (ObservableCollection<string>) GetValue(FilesCollectionProperty);
            set => SetValue(FilesCollectionProperty, value);
        }

        ///// <summary>
        ///// Команда добавления файла
        ///// </summary>
        //public RelayCommand AddCommand
        //{
        //    get => (RelayCommand)GetValue(AddCommandProperty);
        //    set => SetValue(AddCommandProperty, value);
        //}

        /// <summary>
        /// Создает экземпляр <see cref="FilesListControl"/>
        /// </summary>
        public FilesListControl()
        {
            FileControls = new ObservableCollection<FileControl>();
            FilesCollection = new ObservableCollection<string>();

            FileControls.Add(new FileControl() {FileName = "File"});
            FileControls.Add(new FileControl() {FileName = "File"});

            InitializeComponent();
        }

        /// <summary>
        /// Обработчик изменения свойства <see cref="FilesCollection"/>
        /// </summary>
        /// <param name="value"></param>
        private void FilesCollectionChanged(object value)
        {
            if (FilesCollection != null)
            {
                FilesCollection.CollectionChanged += FilesCollection_CollectionChanged;
            }
        }

        /// <summary>
        /// Событие изменения коллекции файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                {
                    FileControls.Add(new FileControl() {FileName = e.NewItems[0] as string});
                    break;
                }
                case NotifyCollectionChangedAction.Remove:
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения свойства <see cref="FilesCollection"/>
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void FilesCollectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((FilesListControl)d).FilesCollectionChanged(e.NewValue);
        }
    }
}
