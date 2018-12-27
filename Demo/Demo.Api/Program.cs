using Demo.EntityFramework;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Demo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {

                var services = scope.ServiceProvider;

                try
                {
                    var demoContext = services.GetService<DemoContext>();
                    DemoContextSeed.Seed(demoContext);

                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex);
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
