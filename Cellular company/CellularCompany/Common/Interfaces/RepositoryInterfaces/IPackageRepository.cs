using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface IPackageRepository
    {
        Task<PackageDto> CreatePackage(PackageDto package);
        Task<bool> DeletePackage(int id);
        Task<PackageDto> UpdatePackage(PackageDto package, int lineId, string clientId);
        PackageDto GetPackage(int id);
        IEnumerable<PackageDto> GetPackages();
    }
}
