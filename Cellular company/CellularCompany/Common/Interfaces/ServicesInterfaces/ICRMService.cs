using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.ServicesInterfaces
{
    
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        void AddClient(ClientDto client);
        [OperationContract]
        Task<IEnumerable<ClientTypeDto>> GetClientTypes();
        [OperationContract]
        Task<IEnumerable<ClientDto>> GetClients();
        [OperationContract]
        LineDto GetLine(string number);
        [OperationContract]
        Task<ClientDto> UpdateClient(string id, ClientDto client);
        [OperationContract]
        Task<IEnumerable<string>> GetClientsIds();
        [OperationContract]
        bool RemoveClient(string id);
        [OperationContract]
        IEnumerable<LineDto> GetLines();
    }
}
