using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand Click { get; set; }
        private string _textOnClick;

        public string TextOnClick
        {
            get { return _textOnClick; }
            set { _textOnClick = value; OnPropertyChange(); }
        }

        public MainViewModel()
        {
            Relaycommands();
        }

        private void Relaycommands()
        {
            Click = new RelayCommand(() => 
            {
                TextOnClick = "Test blah!";
            });
            
        }
    }
}
