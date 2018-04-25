using Autofac;
using Autofac.Integration.Wcf;
using Common.Interfaces.BLInterfaces.GroupManagersInterfaces;
using Common.Interfaces.ServicesInterfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class CRMService: ICRMService
    {
        private readonly ICRMManager _manager;

        public CRMService(ICRMManager manager)
        {
            _manager = manager;
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

        public IEnumerable<ClientTypeDto> GetClientTypes()
        {
            try
            {
                var a = _manager.GetClientTypes().ToList();
                return a;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<ClientDto> GetClients()
        {
            try
            {
                var a = _manager.GetClients().ToList();
                return a;
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
                return _manager.FindLineByNumber(number);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
