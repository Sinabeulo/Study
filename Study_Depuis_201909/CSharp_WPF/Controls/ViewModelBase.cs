using System.ComponentModel;

namespace CSharp_WPF.Controls
{
    public class ViewModelBase : INotifyPropertyChanged
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
    }
}
