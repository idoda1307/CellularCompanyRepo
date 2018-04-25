using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface IPackageIncludesRepository
    {
        Task<PackageIncludesDto> CreatePackageInclude(PackageIncludesDto package);
        Task<bool> DeletePackageInclude(int id);
        Task<PackageIncludesDto> UpdatePackageInclude(PackageIncludesDto packageIncludes);
        PackageIncludesDto GetPackageInclude(int id);
        IEnumerable<PackageIncludesDto> GetPackageIncludes();
    }
}
