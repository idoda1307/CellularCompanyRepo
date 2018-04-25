using Autofac;
using BL.ModulesRegistration;
using Common.Interfaces;
using Common.Interfaces.BLInterfaces;
using Common.Interfaces.BLInterfaces.GroupManagersInterfaces;
using Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces;
using Common.Models;
using DAL;
using DAL.Models;
using Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GroupManagers.Managers
{
    public class CRMManager : ICRMManager
    {
        Object obj = new Object();
        IClientManager clientManager;
        IPackageManager packageManager;
        IClientTypeManager clientTypeManager;
        ILineManager lineManager;

        public CRMManager()
        {

        }
        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterCRMModule();
        }

        public async Task<ClientDto> AddClient(ClientDto client)
        {
            Task<ClientDto> clientDto;
            lock (obj)
            {
                clientManager = GetContainer().Resolve<IClientManager>();
                clientDto = clientManager.AddClientDto(client);
            }
            return await clientDto;
        }

        public async Task<bool> RemoveClient(string id)
        {
            Task<bool> isDeleted;
            lock (obj)
            {
                clientManager = GetContainer().Resolve<IClientManager>();
                isDeleted = clientManager.RemoveClientDto(id);
            }
            return await isDeleted;
        }

        public async Task<ClientDto> UpdateClient(ClientDto client,string clientId)
        {
            Task<ClientDto> clientDto;
            lock (obj)
            {
                clientManager = GetContainer().Resolve<IClientManager>();
                clientDto = clientManager.UpdateClientDto(client,clientId);
            }
            return await clientDto;
        }

        public async Task<PackageDto> UpdatePackage(string clientId,int lineId,PackageDto package)
        {
            Task<PackageDto> packageDto;
            lock (obj)
            {
                packageManager = GetContainer().Resolve<IPackageManager>();
                packageDto = packageManager.UpdatePackageDto(package, lineId, clientId);
            }
            return await packageDto;
        }

        public async Task<ClientDto> UpdateClientClientType(int typeId,ClientDto client)
        {
            Task<ClientDto> clientDto;
            lock (obj)
            {
                clientManager = GetContainer().Resolve<IClientManager>();
                clientDto = clientManager.UpdateClientClientType(client, typeId);
            }
            return await clientDto;
        }

        public IEnumerable<ClientTypeDto> GetClientTypes()
        {
            try
            {
                List<ClientTypeDto> clientTypeDto;
                lock (obj)
                {
                    clientTypeManager = GetContainer().Resolve<IClientTypeManager>();
                    clientTypeDto = clientTypeManager.AddOrUpdateClientTypeDto().Result.ToList();
                    return clientTypeDto;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<ClientDto> GetClients()
        {
            try
            {
                List<ClientDto> clientDto;
                lock (obj)
                {
                    clientManager = GetContainer().Resolve<IClientManager>();
                    clientDto = clientManager.GetClientDtos().ToList();
                    return clientDto;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<string> GetClientsIds()
        {
            try
            {
                List<string> list;
                lock(obj)
                {
                    clientManager = GetContainer().Resolve<IClientManager>();
                    list = clientManager.GetClientsIds().ToList();
                    return list;
                }
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
                LineDto line;
                lock (obj)
                {
                    lineManager = GetContainer().Resolve<ILineManager>();
                    line = lineManager.GetLineDto(number);
                    return line;
                }
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
                List<LineDto> lines;
                lock (obj)
                {
                    lineManager = GetContainer().Resolve<ILineManager>();
                    lines = lineManager.GetLineDtos().ToList();
                    return lines;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}