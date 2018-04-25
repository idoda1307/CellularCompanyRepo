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
    public class LineRepository : ILineRepository
    {
        public async Task<LineDto> CreateLine(LineDto line)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (line != null)
                    {
                        LineEntity entity = line.ToModel();
                        db.Lines.Add(entity);
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

        public async Task<bool> DeleteLine(string number)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var line = db.Lines.FirstOrDefault(l => l.Number == number);
                    if (line != null)
                    {
                        db.Lines.Remove(line);
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

        public async Task<LineDto> UpdateLine(LineDto line, string clientId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (line != null)
                    {
                        if (line.ClientId == clientId)
                        {
                            LineEntity entity = line.ToModel();
                            entity.LineId = line.LineId;
                            db.Lines.Attach(entity);
                            foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                            {
                                if (propName != "LineId")
                                {
                                    db.Entry(entity).Property(propName).IsModified = true;
                                }
                            }
                            await db.SaveChangesAsync();
                            return entity.ToDto();
                        }
                        return null;
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

        public LineDto GetLineByNumber(string number)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Lines.FirstOrDefault(l => l.Number == number).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public LineDto GetLine(int lineId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Lines.FirstOrDefault(l => l.LineId == lineId).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<LineDto> GetLines()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Lines.Select(l => l.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        //public LineDto FindLineByNumber(string number)
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            LineEntity line = db.Lines.FirstOrDefault(l => l.Number == number);
        //            return line.ToDto();
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }
        //}

        //public IEnumerable<string> GetLinesNumbers()
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            return db.Lines.Select(l => l.Number).ToList();
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
