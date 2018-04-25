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
    public class ClientRepositoryRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientRepository>()
                .As<IClientRepository>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
