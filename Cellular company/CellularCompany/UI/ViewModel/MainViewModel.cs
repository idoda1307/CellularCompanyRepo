using ClientModels;
using ClientModels.Models;
using Common.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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

namespace UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ClientModel ClientInfo { get; set; }
        public string ClientID { get; set; }

        public ObservableCollection<ClientTypeModel> Types { get; set; }
        public ObservableCollection<ClientModel> Clients { get; set; }

        public ICommand SaveClientCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }
        public ICommand CleanClientCommand { get; set; }

        private CRMServiceReference.CRMServiceClient crmService = new CRMServiceReference.CRMServiceClient();

        public MainViewModel()
        {
            try
            {
                ClientInfo = new ClientModel();
                IEnumerable<ClientTypeDto> ClientTypes = crmService.GetClientTypesAsync().Result;
                List<ClientTypeModel> clientTypeList = ClientTypes.Select(c => c.ToModel()).ToList();
                Types = new ObservableCollection<ClientTypeModel>(clientTypeList);
                
               // IEnumerable<ClientDto> Clients = crmService.GetClientsAsync().Result;
                //List<ClientModel> clientList = Clients.Select(c => c.ToModel()).ToList();
                //Clients = new ObservableCollection<ClientModel>(clientList);
                //RaisePropertyChanged(nameof(Clients));
                InitializeCommands();
                SaveClientCommand = new RelayCommand(() =>
                {
                    ClientDto model = ClientInfo.ToDto();
                    crmService.AddClientAsync(model);
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
            }
        }

        public void InitializeCommands()
        {
            DeleteClientCommand = new RelayCommand(() =>
              {
                  //CRMService1.RemoveClientAsync(ClientID);
              });
            CleanClientCommand = new RelayCommand(() =>
              {
                  ClientInfo = null;
                  RaisePropertyChanged(nameof(ClientInfo));
              });
        }
    }
}