using Autofac;
using BL.GroupManagers.Managers;
using Common.Interfaces.BLInterfaces.GroupManagersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Host.Configurations
{
    public class HostConfiguration
    {
        public static IContainer SetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CRMManager>().As<ICRMManager>();
            builder.RegisterType<CRMService>().AsSelf();

            return builder.Build();
        }
    }
}