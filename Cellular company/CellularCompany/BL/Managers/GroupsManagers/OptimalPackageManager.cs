﻿using Autofac;
using BL.ModulesRegistration;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GroupManagers.Managers
{
    public class OptimalPackageManager
    {
        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterOptimalPackageModule();
        }

        public void FindOptimalPackage()
        {

        }
    }
}
