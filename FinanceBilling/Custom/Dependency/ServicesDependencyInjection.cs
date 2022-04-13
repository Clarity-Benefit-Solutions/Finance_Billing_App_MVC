using FinanceBillingService.Interface;
using FinanceBillingService.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBilling.Custom.Dependency
{
    public static class ServicesDependencyInjection
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IErrorLogService, ErrorLogService>();
            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IFileNameService, FileNameService>();
            services.AddTransient<ITblLoggingService, TblLoggingService>();
            services.AddTransient<IAnalyticsService, AnalyticsService>();


            return services;
        }
    }
}
