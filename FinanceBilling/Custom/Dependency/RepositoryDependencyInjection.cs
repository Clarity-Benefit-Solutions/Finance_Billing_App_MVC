using FinanceBillingData.Interface;
using FinanceBillingData.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBilling.Custom.Dependency
{
    public static class RepositoryDependencyInjection
    {
        public static IServiceCollection AddInternalRepositories(this IServiceCollection services)
        {
            services.AddTransient<IErrorLogsRepository, ErrorLogsRepository>();
            services.AddTransient<ICommonRepository, CommonRepository>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IFileNameRepository, FileNameRepository>();
            services.AddTransient<ITblLoggingRepository, TblLoggingRepository>();
            services.AddTransient<IAnalyticsRepository, AnalyticsRepository>();

            return services;
        }
    }
}
