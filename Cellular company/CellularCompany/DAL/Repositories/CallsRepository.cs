using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Models;
using Dtos;
using System.Diagnostics;
using Common.Interfaces.RepositoryInterfaces;

namespace DAL.Repositories
{
    public class CallsRepository: ICallsRepository
    {
        public async Task<CallsDto> CreateCall(CallsDto call)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (call != null)
                    {
                        CallsEntity entity = call.ToModel();
                        db.Calls.Add(entity);
                        await db.SaveChangesAsync();
                        return entity.ToDto();
                    }
                    return null;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<bool> DeleteCall(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var call = db.Calls.FirstOrDefault(c => c.CallId == id);
                    if (call != null)
                    {
                        db.Calls.Remove(call);
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

        public async Task<CallsDto> UpdateCall(CallsDto call)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (call != null)
                    {
                        CallsEntity entity = call.ToModel();
                        entity.CallId = call.CallId;
                        db.Calls.Attach(entity);
                        foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                        {
                            if (propName != "CallId")
                            {
                                db.Entry(entity).Property(propName).IsModified = true;
                            }
                        }
                        await db.SaveChangesAsync();
                        return entity.ToDto();
                    }
                    return null;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
                
            }
        }

        public CallsDto GetCall(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Calls.FirstOrDefault(c => c.CallId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<CallsDto> GetCalls()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Calls.Select(c => c.ToDto()).ToList();
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
