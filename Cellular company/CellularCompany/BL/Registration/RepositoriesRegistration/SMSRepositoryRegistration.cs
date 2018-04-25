using Autofac;
using Common.Interfaces.RepositoryInterfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RepositoriesRegistration
{
    public class SMSRepositoryRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SMSRepository>()
                .As<ISMSRepository>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
