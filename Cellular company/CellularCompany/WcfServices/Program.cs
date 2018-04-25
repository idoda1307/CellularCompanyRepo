using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Wcf;
using Services;

namespace WcfServices
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CRMService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                var builder = new ContainerBuilder();

                // Register your service implementations.
                builder.RegisterType<CRMService>();

                // Set the dependency resolver.
                var container = builder.Build();
                AutofacHostFactory.Container = container;
                Console.ReadLine();
            }
        }
    }
}
