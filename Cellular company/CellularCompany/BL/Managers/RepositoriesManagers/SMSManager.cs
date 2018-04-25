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
    public class SMSManager: ISMSManager
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SMSRepository>()
                    .As<ISMSRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<SMSDto> AddSMSDto(SMSDto dto)
        {
            return await GetContainer().Resolve<ISMSRepository>().CreateSMS(dto);
        }

        public async Task<bool> RemoveSMSDto(int smsId)
        {
            return await GetContainer().Resolve<ISMSRepository>().DeleteSMS(smsId);
        }

        public async Task<SMSDto> UpdateSMSDto(SMSDto dto)
        {
            return await GetContainer().Resolve<ISMSRepository>().UpdateSMS(dto);
        }

        public SMSDto GetSMSDto(int smsId)
        {
            return GetContainer().Resolve<ISMSRepository>().GetSMS(smsId);
        }

        public IEnumerable<SMSDto> GetSMSDtos()
        {
            return GetContainer().Resolve<ISMSRepository>().GetSMSs();
        }
    }
}
