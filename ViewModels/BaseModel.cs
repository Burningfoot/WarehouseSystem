using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarehouseSystem.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static event ViewChange ShowView; //View Wechlser
        private BaseViewModel _currentView;
        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChange(); }
        }

        public BaseViewModel()
        {
            ShowView += (model) => CurrentView = model;
        }

        public void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public static void OnChangeView(BaseViewModel model)
        {
            ShowView?.Invoke(model);
        }
    }
    public delegate void ViewChange(BaseViewModel model);
}
