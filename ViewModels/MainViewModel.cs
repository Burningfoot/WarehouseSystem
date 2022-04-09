using System.Windows.Controls;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand<Button> Click { get; set; }
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
            Click = new RelayCommand<Button>((o) => 
            { 
                
            });
        }
    }
}
