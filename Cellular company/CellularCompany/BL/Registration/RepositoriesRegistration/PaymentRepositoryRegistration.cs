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
    public class PaymentRepositoryRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PaymentRepository>()
                .As<IPaymentRepository>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
