using Autofac;
using BL.Registration.ManagersRegistration;
using BL.Registration.RepositoriesManagersRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ModulesRegistration
{
    public class ModulesRegistrations
    {
        public static IContainer RegisterCRMModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<ClientManagerRegistration>();
            builder.RegisterModule<LineManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();
            builder.RegisterModule<ClientTypeManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterInvoiceModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMManagerRegistration>();
            builder.RegisterModule<CallManagerRegistration>();
            builder.RegisterModule<SMSManagerRegistration>();
            builder.RegisterModule<PaymentManagerRegistration>();
            builder.RegisterModule<PackageIncludesManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterOptimalPackageModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMManagerRegistration>();
            builder.RegisterModule<CallManagerRegistration>();
            builder.RegisterModule<SMSManagerRegistration>();
            builder.RegisterModule<LineManagerRegistration>();
            builder.RegisterModule<PackageIncludesManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();
            builder.RegisterModule<PaymentManagerRegistration>();
            builder.RegisterModule<ClientTypeManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }
    }
}
