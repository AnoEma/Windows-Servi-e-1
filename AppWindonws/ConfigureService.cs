using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace AppWindonws
{
    public class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<MeuWindowsService>(service =>
                {
                    service.ConstructUsing(s => new MeuWindowsService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                configure.RunAsLocalSystem();
                configure.SetServiceName("MeuServicoWindowsComTopshelf");
                configure.SetDisplayName("MeuServicoWindowsComTopshelf");
                configure.SetDescription("Meu serviço Windows com Topshelf");
            });
        }
    }
}
