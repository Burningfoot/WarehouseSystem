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
    public class MainViewModel: BaseViewModel
    {
        private ObservableCollection<Function> _functions;

        public ObservableCollection<Function> Functions
        {
            get { return _functions; }
            set { _functions = value; }
        }

        private Function _selectedFunction;

        public Function SelectedFunction
        {
            get { return _selectedFunction; }
            set { _selectedFunction = value; OnPropertyChange(); }
        }


        public RelayCommand<Button> BackBtn { get; set; }

        public MainViewModel()
        {
            RelayCommands();
            GetFunctions();
        }

        private void GetFunctions()
        {
            Functions = new ObservableCollection<Function>();
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
