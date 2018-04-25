using Autofac;
using BL.Managers.RepositoriesManagers;
using Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registration.RepositoriesManagersRegistration
{
    public class ClientTypeManagerRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientTypeManager>()
                .As<IClientTypeManager>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
