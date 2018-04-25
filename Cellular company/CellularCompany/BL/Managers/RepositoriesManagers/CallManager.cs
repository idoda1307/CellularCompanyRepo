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
    public class CallManager: ICallManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CallsRepository>()
                    .As<ICallsRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<CallsDto> AddCallDto(CallsDto dto)
        {
            return await GetContainer().Resolve<ICallsRepository>().CreateCall(dto);
        }

        public async Task<bool> RemoveCallDto(int callId)
        {
            return await GetContainer().Resolve<ICallsRepository>().DeleteCall(callId);
        }

        public async Task<CallsDto> UpdateCallDto(CallsDto dto)
        {
            return await GetContainer().Resolve<ICallsRepository>().UpdateCall(dto);
        }

        public CallsDto GetCallDto(int callId)
        {
            return GetContainer().Resolve<ICallsRepository>().GetCall(callId);
        }

        public IEnumerable<CallsDto> GetCallsDtos()
        {
            return GetContainer().Resolve<ICallsRepository>().GetCalls();
        }
    }
}
