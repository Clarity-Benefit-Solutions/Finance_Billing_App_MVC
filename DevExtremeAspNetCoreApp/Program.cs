using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceBillingData.Interface;
using FinanceBillingData.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DevExtremeAspNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureServices((_, services) => services
            .AddScoped<IErrorLogsRepository, ErrorLogsRepository>()
            .AddScoped<ICommonRepository, CommonRepository>()
            .AddScoped<IInvoiceRepository, InvoiceRepository>()
            );

    }
}