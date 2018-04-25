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
    public class SelectedNumbersManager: ISelectedNumbersManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SelectedNumbersRepository>()
                    .As<ISelectedNumbersRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<SelectedNumbersDto> AddSelectedNumberDto(SelectedNumbersDto dto)
        {
            return await GetContainer().Resolve<ISelectedNumbersRepository>().CreateSelectedNumber(dto);
        }

        public async Task<bool> RemoveSelectedNumberDto(int numberId)
        {
            return await GetContainer().Resolve<ISelectedNumbersRepository>().DeleteSelectedNumber(numberId);
        }

        public async Task<SelectedNumbersDto> UpdateSelectedNumberDto(SelectedNumbersDto dto)
        {
            return await GetContainer().Resolve<ISelectedNumbersRepository>().UpdateSelectedNumber(dto);
        }

        public SelectedNumbersDto GetSelectedNumberDto(int numberId)
        {
            return GetContainer().Resolve<ISelectedNumbersRepository>().GetSelectedNumber(numberId);
        }

        public IEnumerable<SelectedNumbersDto> GetSelectedNumberDtos()
        {
            return GetContainer().Resolve<ISelectedNumbersRepository>().GetSelectedNumbers();
        }
    }
}
