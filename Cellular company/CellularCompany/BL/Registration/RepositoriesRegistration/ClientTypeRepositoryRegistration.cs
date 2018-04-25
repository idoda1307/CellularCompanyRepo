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
    public class ClientTypeRepositoryRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientTypeRepository>()
                .As<IClientTypeRepository>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
