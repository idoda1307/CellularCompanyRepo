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
    public class PackageManager:IPackageManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PackageRepository>()
                    .As<IPackageRepository>()
                    .SingleInstance();
            return builder.Build();
        }
        
        public async Task<PackageDto> AddPackageDto(PackageDto dto)
        {
            return await GetContainer().Resolve<IPackageRepository>().CreatePackage(dto);
        }

        public async Task<bool> RemovePackageDto(int packageId)
        {
            return await GetContainer().Resolve<IPackageRepository>().DeletePackage(packageId);
        }

        public async Task<PackageDto> UpdatePackageDto(PackageDto dto,int lineId,string clientId)
        {
            return await GetContainer().Resolve<IPackageRepository>().UpdatePackage(dto,lineId,clientId);
        }

        public PackageDto GetPackageDto(int packageId)
        {
            return GetContainer().Resolve<IPackageRepository>().GetPackage(packageId);
        }

        public IEnumerable<PackageDto> GetPackageDtos()
        {
            return GetContainer().Resolve<IPackageRepository>().GetPackages();
        }

    }
}
