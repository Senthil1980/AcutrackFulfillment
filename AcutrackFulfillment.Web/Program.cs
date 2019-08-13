using AcutrackFulfillment.Infrastructure.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AcutrackFulfillmentRWS
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateWebHostBuilder(args)
                       .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var appdbContext = services.GetRequiredService<AppDbContext>();
                    await AppDbContextSeed.SeedAsync(appdbContext);
                   
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public  static  IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
             .ConfigureLogging(builder =>
             {
                 builder.SetMinimumLevel(LogLevel.Warning);               
                 builder.AddFilter("IdentityServer4", LogLevel.Debug);
                 builder.AddFilter("AcutrackFulfillment.Infrastructure", LogLevel.Debug);
             })
                .UseStartup<Startup>();
    }
}
