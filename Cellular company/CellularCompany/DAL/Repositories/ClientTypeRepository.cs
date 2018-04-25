using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Models.ClientTypeEntity;
using Common.Interfaces;
using Common.Models;
using Dtos;
using System.Diagnostics;
using Common.Interfaces.RepositoryInterfaces;
using System.Data.Entity.Migrations;

namespace DAL.Repositories
{
    public class ClientTypeRepository : IClientTypeRepository
    {
        public IEnumerable<ClientTypeDto> GetClientTypes()
        {
            return new List<ClientTypeDto>()
            {
                new ClientTypeDto()
                        {
                    ClientTypeId=1,
                            TypeName = "business",
                            MinutePrice = 1,
                            SMSPrice = 0.5
                        },
                            new ClientTypeDto()
                            {
                                ClientTypeId=2,
                                TypeName = "Private",
                                MinutePrice = 1.5,
                                SMSPrice = 1
                            },
                            new ClientTypeDto()
                            {
                                ClientTypeId=3,
                                TypeName = "VIP",
                                MinutePrice = 0.5,
                                SMSPrice = 0.25
                            }
            };

        }

        public async Task<List<ClientTypeDto>> AddOrUpdateClientType()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    List<ClientTypeEntity> list = GetClientTypes().Select(c => c.ToModel()).ToList();
                    foreach (var item in list)
                    {
                        db.ClientType.AddOrUpdate(t => t.TypeName, item);
                    }
                    await db.SaveChangesAsync();
                    List<ClientTypeDto> clientTypes = db.ClientType.ToList().Select(c => c.ToDto()).ToList();
                    return clientTypes;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<bool> DeleteClientType(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var clientEntity = db.ClientType.FirstOrDefault(c => c.ClientTypeId == id);
                    if (clientEntity != null)
                    {
                        db.ClientType.Remove(clientEntity);
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

        //public async Task<ClientTypeDto> UpdateClientType(ClientTypeDto clientType)
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            if (clientType != null)
        //            {
        //                ClientTypeEntity entity = clientType.ToModel();
        //                entity.ClientTypeId = clientType.ClientTypeId;
        //                db.ClientType.Attach(entity);
        //                foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
        //                {
        //                    if (propName != "ClientTypeId")
        //                    {
        //                        db.Entry(entity).Property(propName).IsModified = true;
        //                    }
        //                }
        //                await db.SaveChangesAsync();
        //                return entity.ToDto();
        //            }
        //            return null;
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }
        //}

        public ClientTypeDto GetClientType(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.ClientType.FirstOrDefault(c => c.ClientTypeId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        //public IEnumerable<ClientTypeDto> GetClientTypes()
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            Initializer.InitializeClientType();
        //            return db.ClientType.Select(c => c.ToDto()).ToList();
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }
        //}
    }
}
