using Autofac;
using Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces;
using Common.Interfaces.RepositoryInterfaces;
using Common.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.RepositoriesManagers
{
    public class PackageIncludesManager: IPackageIncludesManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PackageIncludesRepository>()
                    .As<IPackageIncludesRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<PackageIncludesDto> AddPackageIncludesDto(PackageIncludesDto dto)
        {
            return await GetContainer().Resolve<IPackageIncludesRepository>().CreatePackageInclude(dto);
        }

        public async Task<bool> RemovePackageIncludesDto(int packageIncludeId)
        {
            return await GetContainer().Resolve<IPackageIncludesRepository>().DeletePackageInclude(packageIncludeId);
        }

        public async Task<PackageIncludesDto> UpdatePackageIncludesDto(PackageIncludesDto dto)
        {
            return await GetContainer().Resolve<IPackageIncludesRepository>().UpdatePackageInclude(dto);
        }

        public PackageIncludesDto GetPackageIncludesDto(int packageId)
        {
            return GetContainer().Resolve<IPackageIncludesRepository>().GetPackageInclude(packageId);
        }

        public IEnumerable<PackageIncludesDto> GetPackageIncludesDtos()
        {
            return GetContainer().Resolve<IPackageIncludesRepository>().GetPackageIncludes();
        }
    }
}
