using C4M.BackgroundTasks.Services;
using C4M.BackgroundTasks.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace C4M.BackgroundTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            //.ConfigureAppConfiguration((context, builder) =>
            //{
            //    builder
            //       .AddJsonFile("appsettings.json")
            //       .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json")
            //       .AddEnvironmentVariables()
            //       .Build();
            //})
            .ConfigureServices((hostContext, services) =>
                {
                    IConfiguration configuration = hostContext.Configuration;

                    var settings = configuration.GetSection("C4MSettings").Get<List<BackgroundTaskSettings.C4MSettings>>();
                    var apiSettings = configuration.GetSection("C4MApiSettings").Get<BackgroundTaskSettings.C4MApiSettings>();

                    services.AddHttpClient<IC4MService, C4MService>();

                    services.AddSingleton(settings);
                    services.AddSingleton(apiSettings);
                    services.AddHttpClient();
                    services.AddHostedService<Worker>();
                });
    }
}
