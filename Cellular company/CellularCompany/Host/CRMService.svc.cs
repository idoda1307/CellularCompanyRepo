using Common.Interfaces.BLInterfaces.GroupManagersInterfaces;
using Common.Interfaces.ServicesInterfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class CRMService : ICRMService
    {
        private readonly ICRMManager _manager;

        public CRMService(ICRMManager manager)
        {
            try
            {
                _manager = manager;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void AddClient(ClientDto client)
        {
            try
            {
                _manager.AddClient(client);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public bool RemoveClient(string id)
        {
            try
            {
                _manager.RemoveClient(id);
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<IEnumerable<ClientTypeDto>> GetClientTypes()
        {
            try
            {
                var task = Task.Factory.StartNew(() =>
                {
                    var a = _manager.GetClientTypes().ToList();
                    return a;
                });
                return await task.ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<ClientDto>> GetClients()
        {
            try
            {
                var task = Task.Factory.StartNew(() =>
                {
                    var a = _manager.GetClients().ToList();
                    return a;
                });
                return await task.ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public LineDto GetLine(string number)
        {
            try
            {
                return _manager.GetLine(number);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<LineDto> GetLines()
        {
            try
            {
                return _manager.GetLines();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<ClientDto> UpdateClient(string id, ClientDto client)
        {
            try
            {
                return await _manager.UpdateClient(client,id);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<string>> GetClientsIds()
        {
            try
            {
                var task = Task.Factory.StartNew(() =>
                {
                    var a = _manager.GetClientsIds().ToList();
                    return a;
                });
                return await task.ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
