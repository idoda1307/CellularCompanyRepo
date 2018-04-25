using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using ClientModels.Models;
using System.Windows.Input;
using System.Diagnostics;
using ClientModels;
using GalaSoft.MvvmLight.Views;
using Client.ServerServiceReference;

namespace Client.ViewModel
{
    public class ClientViewModel : ViewModelBase
    {
        private ObservableCollection<string> _clientsIds = new ObservableCollection<string>();
        private ObservableCollection<ClientTypeModel> _types = new ObservableCollection<ClientTypeModel>();

        private readonly INavigationService _navigationService;

        private int _clientTypeId;

        public int ClientTypeId
        {
            get { return _clientTypeId; }
            set { _clientTypeId = value; RaisePropertyChanged(nameof(ClientTypeId)); }
        }

        private string _clientID;
        private ClientModel _clientInfo { get; set; }

        public RelayCommand NavigateCommand { get; private set; }
        public ICommand SaveClientCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }
        public ICommand CleanClientCommand { get; set; }

        private CRMServiceClient server = new CRMServiceClient();

        
        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; RaisePropertyChanged(nameof(ClientID)); }
        }

        public ClientModel ClientInfo
        {
            get { return _clientInfo; }
            set { _clientInfo = value; RaisePropertyChanged(nameof(ClientInfo)); }
        }

        public ObservableCollection<ClientTypeModel> Types
        {
            get { return _types; }
            set { _types = value; RaisePropertyChanged("Types"); }
        }
        public ObservableCollection<string> ClientsIds
        {
            get { return _clientsIds; }
            set { _clientsIds = value; RaisePropertyChanged(nameof(ClientsIds)); }
        }

        public ClientViewModel(INavigationService navigationService)
        {
            try
            {
                _navigationService = navigationService;
                ClientInfo = new ClientModel();
                var getTypesTask = Task.Factory.StartNew(() => GetClientTypes());
                Types = new ObservableCollection<ClientTypeModel>(getTypesTask.Result.Result);
                var task = Task.Factory.StartNew(() => server.GetClientsIdsAsync());
                ClientsIds = new ObservableCollection<string>(task.Result.Result);
                InitializeCommands();
                SaveClientCommand = new RelayCommand(() =>
                {
                    //ClientInfo.ClientTypeId = ClientTypeId;
                    ClientDto model = ClientInfo.ToDto();
                    if (ClientID == null)
                        server.AddClientAsync(model);
                    else
                        server.UpdateClientAsync(ClientID, ClientInfo.ToDto());
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
            }
        }

        public async Task<IEnumerable<ClientTypeModel>> GetClientTypes()
        {
            try
            {
                List<ClientTypeDto> ClientTypes = await server.GetClientTypesAsync();
                List<ClientTypeModel> clientTypeList = ClientTypes.Select(c => c.ToModel()).ToList();
                return clientTypeList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void InitializeCommands()
        {
            DeleteClientCommand = new RelayCommand(() =>
            {
                server.RemoveClientAsync(ClientID);
                RaisePropertyChanged(nameof(ClientsIds));
            });
            CleanClientCommand = new RelayCommand(() =>
            {
                ClientInfo = null;
                RaisePropertyChanged(nameof(ClientInfo));
            });
        }
    }
}