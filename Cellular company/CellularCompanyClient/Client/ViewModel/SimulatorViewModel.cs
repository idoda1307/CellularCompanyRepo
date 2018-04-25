using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class SimulatorViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public SimulatorViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
