using CSharp_WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSharp_WPF.ViewModel
{
    public class FileIOExamplesViewModel : ViewModelBase
    {
        private FileManager _fileManager;
        public ICommand GetBinaryDataCommand { get; set; }
        public FileIOExamplesViewModel()
        {
            GetBinaryDataCommand = new CommandControl(ExecuteGetBinaryDataCommand);

            _fileManager = new FileManager();
        }

        #region Execute
        private void ExecuteGetBinaryDataCommand(object obj)
        {
            _fileManager.GetFileToBinaryData();
        }
        #endregion
    }
}
