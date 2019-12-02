using System;
using Topshelf;

namespace AspNetCoreTopshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(options =>
            {
                options.Service<Service>(configurator =>
                {
                    configurator.ConstructUsing(() => new Service());
                    configurator.WhenStarted(service => service.Start());
                    configurator.WhenStopped(service => service.Stop());
                });

                options.EnableServiceRecovery(recoveryOptions =>
                {
                    recoveryOptions.RestartService(1);
                });

                options.StartAutomatically();
            });
        }
    }
}