using System.Windows.Controls;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        static event ViewChange ShowView; //View Wechlser
        private BaseViewModel _currentView;

        static private MainViewModel _instance;

        static public MainViewModel Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                else
                    return _instance = new MainViewModel();
            }
        }
        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChange(); }
        }
        public MainViewModel()
        {
            CurrentView = new ViewModel_StartScreen();
            ShowView += (model) => CurrentView = model;
            _instance = this;

        }
        public static void OnChangeView(BaseViewModel model)
        {
            ShowView?.Invoke(model);
        }
    }
    public delegate void ViewChange(BaseViewModel model);
}
