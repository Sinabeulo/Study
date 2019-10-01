using CSharp_WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CSharp_WPF
{
    public class Navigation : ViewModelBase
    {
        private UserControl _contentWindow;

        public UserControl ContentWindow
        {
            get => _contentWindow;
            set => SetProperty(ref _contentWindow, nameof(ContentWindow), value);
        }

        private static Navigation _instance;

        /// Singleton 방법 1
        //public static Navigation Instance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new Navigation();
        //    }
        //
        //    return _instance;
        //}

        /// Singleton 방법 1
        static public Navigation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Navigation();
                return _instance;
            }
        }

        //public Navigation()
        //{
        //    if(_instance == null)
        //    {
        //        _instance = new Navigation();
        //    }
        //}

    }
}
