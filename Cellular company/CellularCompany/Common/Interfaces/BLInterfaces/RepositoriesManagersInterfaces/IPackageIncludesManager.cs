using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface IPackageIncludesManager
    {
        Task<PackageIncludesDto> AddPackageIncludesDto(PackageIncludesDto dto);
        Task<bool> RemovePackageIncludesDto(int packageIncludeId);
        Task<PackageIncludesDto> UpdatePackageIncludesDto(PackageIncludesDto dto);
        PackageIncludesDto GetPackageIncludesDto(int packageId);
        IEnumerable<PackageIncludesDto> GetPackageIncludesDtos();
    }
}
