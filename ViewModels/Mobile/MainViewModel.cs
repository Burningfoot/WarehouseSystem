using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels.Mobile
{
    public class MainViewModel: BaseViewModel
    {
        public RelayCommand<Button> BackBtn { get; set; }

        public MainViewModel()
        {
            RelayCommands();
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
