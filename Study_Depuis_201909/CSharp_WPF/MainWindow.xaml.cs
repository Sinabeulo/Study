using CSharp_WPF.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(ref T prop, string propName, T value)
        {
            prop = value;

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion

        //private UserControl _contentWindow;

        //public UserControl ContentWindow
        //{
        //    get => _contentWindow;
        //    set => SetProperty(ref _contentWindow, nameof(ContentWindow), value);
        //}

        //internal void SetNewContent(UserControl _content)
        //{
        //    ContentWindow = _content;
        //}
        //private Navigation _contentNavigation;

        //public Navigation ContentNavigation
        //{
        //    get => _contentNavigation;
        //    set => SetProperty(ref _contentNavigation, nameof(ContentNavigation), value);
        //}

        public MainWindow()
        {
            InitializeComponent();

            //ContentNavigation = new Navigation()
            //{
            //    ContentWindow = new MainView()
            //};
            //this.DataContext = ContentNavigation;
            //ContentWindow = new MainView();
            //GrobalContentNavigation.ContentWindow = new MainView();

            //this.DataContext = GrobalContentNavigation;
            //GrobalContentNavigation = new Navigation();
            //GrobalContentNavigation = new FileIOExamples();
            Navigation.Instance.ContentWindow = new MainView();
            this.DataContext = Navigation.Instance;
        }
        
    }
}
