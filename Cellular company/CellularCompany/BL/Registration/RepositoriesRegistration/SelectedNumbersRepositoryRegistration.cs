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
    public class SelectedNumbersRepositoryRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SelectedNumbersRepository>()
                .As<ISelectedNumbersRepository>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}
