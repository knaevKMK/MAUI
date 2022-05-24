using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Temp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy;
        string pageTitle;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public string PageTitle
        {
            get => pageTitle;
            set
            {
                if (pageTitle == value)
                    return;
                pageTitle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }

        public bool IsNotBusy => !IsBusy;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}