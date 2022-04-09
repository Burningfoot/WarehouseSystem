using System.Windows.Controls;
using WarehouseSystem.Models.Tools;

namespace WarehouseSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            CurrentView = new ViewModel_StartScreen();
            
        }
    }  
}
