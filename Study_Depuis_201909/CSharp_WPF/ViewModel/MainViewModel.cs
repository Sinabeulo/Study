using CSharp_WPF.Controls;
using CSharp_WPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CSharp_WPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand FileExampleCommand { get; set; }
        public MainViewModel()
        {
            FileExampleCommand = new CommandControl(ExecuteFileExampleCommand);
        }

        /// <summary>
        /// 파일 예제
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteFileExampleCommand(object obj)
        {
            //UserControl uc = new FileIOExamplesView();

            Navigation.Instance.ContentWindow = new FileIOExamplesView();
            //Navigation nv = new Navigation()
            //{
            //    ContentWindow = new FileIOExamplesView()
            //};
        }
    }
}
