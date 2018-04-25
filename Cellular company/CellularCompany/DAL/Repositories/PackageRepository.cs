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
    public class PackageRepository : IPackageRepository
    {
        public async Task<PackageDto> CreatePackage(PackageDto package)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (package != null)
                    {
                        PackageEntity entity = package.ToModel();
                        db.Packages.Add(entity);
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

        public async Task<bool> DeletePackage(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var package = db.Packages.FirstOrDefault(p => p.PackageId == id);
                    if (package != null)
                    {
                        db.Packages.Remove(package);
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

        public async Task<PackageDto> UpdatePackage(PackageDto package, int lineId, string clientId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (package != null)
                    {
                        if (CheckIfPackageBelongsToClient(package, lineId, clientId))
                        {
                            PackageEntity entity = package.ToModel();
                            entity.PackageId = package.PackageId;
                            db.Packages.Attach(entity);
                            foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                            {
                                if (propName != "PackageId")
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

        public PackageDto GetPackage(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Packages.FirstOrDefault(p => p.PackageId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<PackageDto> GetPackages()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.Packages.Select(p => p.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        private bool CheckIfPackageBelongsToClient(PackageDto package, int lineId, string clientId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    LineRepository lineRepository = new LineRepository();
                    LineDto line = lineRepository.GetLine(lineId);
                    if (line != null)
                    {
                        if (line.PackageId == package.PackageId)
                        {
                            if (line.ClientId == clientId)
                                return true;
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return false;
            }
        }
    }
}
