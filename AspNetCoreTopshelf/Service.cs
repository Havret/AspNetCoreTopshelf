using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebApplication;

namespace AspNetCoreTopshelf
{
    public class Service
    {
        private IHost _webHost;

        public void Start()
        {
            _webHost = CreateHostBuilder().Build();
            _webHost.Start();
        }
        
        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

        public void Stop()
        {
            _webHost?.StopAsync().Wait();
            _webHost?.Dispose();
        }
    }
}