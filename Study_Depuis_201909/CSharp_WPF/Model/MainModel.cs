using CSharp_WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CSharp_WPF.Model
{
    class MainModel : ViewModelBase
    {
        private UserControl _contentWindow;

        public MainModel() { }

        //internal void SetNewContent(UserControl _content)
        //{
        //    ContentWindow = _content;
        //}

        public UserControl ContentWindow
        {
            get => _contentWindow; 
            set => SetProperty(ref _contentWindow, nameof(ContentWindow), value);
        }
    }
}
