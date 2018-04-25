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
    public class CallManagerRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CallManager>()
                .As<ICallManager>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
