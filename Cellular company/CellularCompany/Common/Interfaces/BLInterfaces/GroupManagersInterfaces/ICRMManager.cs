using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.GroupManagersInterfaces
{
    public interface ICRMManager
    {
        Task<ClientDto> AddClient(ClientDto client);
        IEnumerable<ClientTypeDto> GetClientTypes();
        IEnumerable<ClientDto> GetClients();
        Task<bool> RemoveClient(string id);
        Task<ClientDto> UpdateClient(ClientDto client,string clientId);
        IEnumerable<string> GetClientsIds();
        LineDto GetLine(string number);
        IEnumerable<LineDto> GetLines();
        //void UpdateClient(int id, ClientDto client);
        //void UpdateClientType(int clientId, ClientTypeDto type);
        //void UpdatePackages(int lineId, PackageDto package);
        //List<ClientDto> GetClients();

    }
}
