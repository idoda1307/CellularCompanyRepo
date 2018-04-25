using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace Client.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand NavigateToClient { get; private set; }
        public RelayCommand NavigateToLines { get; private set; }
        public RelayCommand NavigateToSimulator { get; set; }
        public RelayCommand NavigateToPayment { get; set; }

        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToClient = new RelayCommand(NavigateToClientCommandAction);
            NavigateToLines = new RelayCommand(NavigateToLinesCommandAction);
            NavigateToSimulator = new RelayCommand(NavigateToSimulatorCommandAction);
            NavigateToPayment = new RelayCommand(NavigateToPaymentCommandAction);
        }

        private void NavigateToPaymentCommandAction()
        {
            _navigationService.NavigateTo("PaymentPage");
        }

        private void NavigateToSimulatorCommandAction()
        {
            _navigationService.NavigateTo("SimulatorPage");
        }

        private void NavigateToLinesCommandAction()
        {
            _navigationService.NavigateTo("LinesPage");
        }

        private void NavigateToClientCommandAction()
        {
            try
            {
                _navigationService.NavigateTo("CustomersPage");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }



    }
}