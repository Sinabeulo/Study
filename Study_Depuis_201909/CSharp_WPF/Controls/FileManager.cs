using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_WPF.Controls
{   
    public class FileManager
    {
        readonly private string defaultPath = Environment.CurrentDirectory;
        private OpenFileDialog _fileDialog;

        public FileManager()
        {
            _fileDialog = new OpenFileDialog();
        }

        #region Private
        /// <summary>
        /// Get File Name From File Dialog 
        /// </summary>
        /// <returns></returns>
        private string GetFileName()
        {
            if (_fileDialog == null) return "Error";
            _fileDialog.ShowDialog();

            return _fileDialog.FileName;
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        public void GetFileToBinaryData()
        {
            string fileName = GetFileName();

            byte[] filedata = File.ReadAllBytes(fileName);
            StringBuilder sb = new StringBuilder(); ;

            foreach (byte b in filedata)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            var fileDir = fileName.Split('\\');
            fileName = fileDir[fileDir.Length - 1].Split('.')[0];

            File.WriteAllText(defaultPath+$"\\{fileName}.txt", sb.ToString());
            //https://stackoverflow.com/questions/2426190/how-to-read-file-binary-in-c
        }

    }

}
