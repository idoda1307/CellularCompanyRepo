﻿
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Common.Interfaces;
using Common.Models;
using Dtos;
using Common.Interfaces.RepositoryInterfaces;

namespace DAL.Repositories
{
    public class ClientRepository: IClientRepository
    {
        public async Task<ClientDto> CreateClient(ClientDto client)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (client != null)
                    {
                        ClientEntity entity = client.ToModel();
                        db.Clients.Add(entity);
                        await db.SaveChangesAsync();
                        return entity.ToDto();
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<bool> DeleteClient(string id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var client = db.Clients.FirstOrDefault(c => c.ClientId == id);
                    if (client != null)
                    {
                        db.Clients.Remove(client);
                        await db.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public async Task<ClientDto> UpdateClient(ClientDto client,string clientId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (client != null)
                    {
                        client.ClientId = clientId;
                        ClientEntity entity = client.ToModel();
                        db.Clients.Attach(entity);
                        foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                        {
                            if (propName != "ClientId")
                            {
                                db.Entry(entity).Property(propName).IsModified = true;
                            }
                        }
                        await db.SaveChangesAsync();
                        return entity.ToDto();
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<ClientDto> UpdateClientClientType(ClientDto client,int typeId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (client != null && typeId != 0)
                    {
                        ClientEntity clientEntity = db.Clients.FirstOrDefault(c => c.ClientId == client.ClientId);
                        clientEntity.ClientTypeId = typeId;
                        db.Entry(clientEntity).Property(nameof(clientEntity.ClientTypeId)).IsModified = true;
                        await db.SaveChangesAsync();
                        return clientEntity.ToDto();
                    }
                    return null;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return null;
            }
        }

        public ClientDto GetClient(string id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Clients.FirstOrDefault(c => c.ClientId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public List<ClientDto> GetClients()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var a = db.Clients.ToList();
                    var b=a.Select(c => c.ToDto()).ToList();
                    return b;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<string> GetClientIds()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Clients.Select(c => c.ClientId).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}
