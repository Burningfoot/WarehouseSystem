using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WarehouseSystem.Models.Functions;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels.Mobile
{
    public class MainViewModelMobile: BaseViewModel
    {
        private ObservableCollection<IFunction> _functions;

        public ObservableCollection<IFunction> Functions
        {
            get { return _functions; }
            set { _functions = value; }
        }

        private IFunction _selectedFunction;

        public IFunction SelectedFunction
        {
            get { return _selectedFunction; }
            set { _selectedFunction = value; OnPropertyChange(); }
        }


        public RelayCommand<Button> BackBtn { get; set; }

        public MainViewModelMobile()
        {
            RelayCommands();
            GetFunctions();
        }

        private void GetFunctions()
        {
            Functions = new ObservableCollection<IFunction>();
            Functions.Add(new Data());
            Functions.Add(new NewCustomer());
        }

        private void RelayCommands()
        {
            BackBtn = new RelayCommand<Button>((o) => 
            { 
                ViewModels.MainViewModel.OnChangeView(new ViewModel_StartScreen());
            });
        }
    }
}
