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
    public class LineManager: ILineManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LineRepository>()
                    .As<ILineRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<LineDto> AddLineDto(LineDto dto)
        {
            return await GetContainer().Resolve<ILineRepository>().CreateLine(dto);
        }

        public async Task<bool> RemoveLineDto(string number)
        {
            return await GetContainer().Resolve<ILineRepository>().DeleteLine(number);
        }

        public async Task<LineDto> UpdateLineDto(LineDto dto, string clientId)
        {
            return await GetContainer().Resolve<ILineRepository>().UpdateLine(dto, clientId);
        }

        public LineDto GetLineDto(string number)
        {
            return GetContainer().Resolve<ILineRepository>().GetLineByNumber(number);
        }

        public IEnumerable<LineDto> GetLineDtos()
        {
            return GetContainer().Resolve<ILineRepository>().GetLines();
        }
    }
}
