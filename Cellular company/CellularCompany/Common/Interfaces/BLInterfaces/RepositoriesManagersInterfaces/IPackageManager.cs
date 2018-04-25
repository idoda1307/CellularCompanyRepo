using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface IPackageManager
    {
        Task<PackageDto> AddPackageDto(PackageDto dto);
        Task<bool> RemovePackageDto(int packageId);
        Task<PackageDto> UpdatePackageDto(PackageDto dto, int lineId, string clientId);
        PackageDto GetPackageDto(int packageId);
        IEnumerable<PackageDto> GetPackageDtos();

    }
}
