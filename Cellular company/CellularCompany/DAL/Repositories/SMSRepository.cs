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
    public class SMSRepository: ISMSRepository
    {
        public async Task<SMSDto> CreateSMS(SMSDto sms)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (sms != null)
                    {
                        SMSEntity entity = sms.ToModel();
                        db.SMS.Add(entity);
                        await db.SaveChangesAsync();
                        return sms;
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

        public async Task<bool> DeleteSMS(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var sms = db.SMS.FirstOrDefault(s => s.SMSId == id);
                    if (sms != null)
                    {
                        db.SMS.Remove(sms);
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

        public async Task<SMSDto> UpdateSMS(SMSDto sms)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (sms != null)
                    {
                        SMSEntity entity = sms.ToModel();
                        entity.SMSId = sms.SMSId;
                        db.SMS.Attach(entity);
                        foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                        {
                            if (propName != "SMSId")
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

        public SMSDto GetSMS(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.SMS.FirstOrDefault(s => s.LineId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<SMSDto> GetSMSs()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.SMS.Select(s => s.ToDto()).ToList();
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
