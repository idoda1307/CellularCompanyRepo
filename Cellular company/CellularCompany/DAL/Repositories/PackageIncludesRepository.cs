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
    public class PackageIncludesRepository: IPackageIncludesRepository
    {
        public async Task<PackageIncludesDto> CreatePackageInclude(PackageIncludesDto package)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (package != null)
                    {
                        PackageIncludesEntity entity = package.ToModel();
                        db.PackageIncludes.Add(entity);
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

        public async Task<bool> DeletePackageInclude(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    var package = db.PackageIncludes.FirstOrDefault(p => p.Id == id);
                    if (package != null)
                    {
                        db.PackageIncludes.Remove(package);
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

        public async Task<PackageIncludesDto> UpdatePackageInclude(PackageIncludesDto packageIncludes)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (packageIncludes != null)
                    {
                        PackageIncludesEntity entity = packageIncludes.ToModel();
                        entity.Id = packageIncludes.Id;
                        db.PackageIncludes.Attach(entity);
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

        public PackageIncludesDto GetPackageInclude(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.PackageIncludes.FirstOrDefault(p => p.PackageId == id).ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<PackageIncludesDto> GetPackageIncludes()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    return db.PackageIncludes.Select(p => p.ToDto()).ToList();
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
