using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatternsTrain.Behavioral.Observer
{
    public class TrackedEntity:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged<T>(T fieldValue, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!fieldValue?.Equals(newValue) ?? true)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
