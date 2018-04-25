using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Dtos;
using Common.Models;
using System.Diagnostics;
using Common.Interfaces.RepositoryInterfaces;

namespace DAL.Repositories
{
    public class SelectedNumbersRepository: ISelectedNumbersRepository
    {
        public async Task<SelectedNumbersDto> CreateSelectedNumber(SelectedNumbersDto number)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (number != null)
                    {
                        SelectedNumbersEntity entity = number.ToModel();
                        db.SelectedNumbers.Add(entity);
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

        public async Task<bool> DeleteSelectedNumber(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var number = db.SelectedNumbers.FirstOrDefault(s => s.Id == id);
                    if (number != null)
                    {
                        db.SelectedNumbers.Remove(number);
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

        public async Task<SelectedNumbersDto> UpdateSelectedNumber(SelectedNumbersDto number)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (number != null)
                    {
                        SelectedNumbersEntity entity = number.ToModel();
                        entity.Id = number.Id;
                        db.SelectedNumbers.Attach(entity);
                        foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                        {
                            if (propName != "Id")
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

        public SelectedNumbersDto GetSelectedNumber(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.SelectedNumbers.FirstOrDefault(s => s.Id == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<SelectedNumbersDto> GetSelectedNumbers()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.SelectedNumbers.Select(s => s.ToDto()).ToList();
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
