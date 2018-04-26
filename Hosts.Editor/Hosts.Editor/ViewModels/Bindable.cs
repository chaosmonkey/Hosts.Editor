using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hosts.Editor.ViewModels
{
    public abstract class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool Set<T>(ref T backer, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(backer, value))
            {
                return false;
            }
            backer = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}