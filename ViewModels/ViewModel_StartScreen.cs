using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels
{
    public class ViewModel_StartScreen: BaseViewModel
    {
        public RelayCommand<Button> Click_Mobile { get; set; }
        public RelayCommand<Button> Click_Home { get; set; }
        public RelayCommand<Button> Click_Admin { get; set; }
        private string _textOnClick;
        public string TextOnClick
        {
            get { return _textOnClick; }
            set { _textOnClick = value; OnPropertyChange(); }
        }
        public ViewModel_StartScreen()
        {
            Relaycommands();
        }
        private void Relaycommands()
        {
            Click_Mobile = new RelayCommand<Button>((o) =>
            {
                TextOnClick = "Mobile!";
                MainViewModel.OnChangeView(new Mobile.MainViewModelMobile());
            });
            Click_Home = new RelayCommand<Button>((o) =>
            {
                TextOnClick = "Home!";
            });
            Click_Admin = new RelayCommand<Button>((o) =>
            {
                TextOnClick = "Admin!";
            });
        }
    }
}
