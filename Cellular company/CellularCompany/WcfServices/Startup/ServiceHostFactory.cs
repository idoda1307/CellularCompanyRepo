using Autofac;
using Autofac.Integration.Wcf;
using BL.GroupManagers.Managers;
using Common.Interfaces.BLInterfaces.GroupManagersInterfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.Startup
{
    public class ServiceHostFactory : AutofacHostFactory
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CRMManager>().As<ICRMManager>();
            builder.RegisterType<CRMService>();
            Container = builder.Build();

            return base.CreateServiceHost(constructorString, baseAddresses);
        }

        protected override ServiceHost CreateSingletonServiceHost(object singletonInstance, Uri[] baseAddresses)
        {
            if (singletonInstance == null)
            {
                throw new ArgumentNullException("singletonInstance");
            }
            if (baseAddresses == null)
            {
                throw new ArgumentNullException("baseAddresses");
            }
            return new ServiceHost(singletonInstance, baseAddresses);
        }


    }
}
