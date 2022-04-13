using AutoMapper;
using FinanceBilling.Custom.Helpers;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingData.Repository;
using FinanceBillingService.Interface;
using FinanceBillingService.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FinanceBilling
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services
                .AddControllersWithViews().AddRazorRuntimeCompilation()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddDbContext<Finance_BillingContext>();
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
           //Repositories
            services.AddSingleton(mapper);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ILoggerManager, LoggerManager>();
            //Repositories
            //services.AddInternalRepositories();
            services.AddScoped<IErrorLogsRepository, ErrorLogsRepository>();
            services.AddScoped<ICommonRepository, CommonRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IFileNameRepository, FileNameRepository>();
            services.AddScoped<ILoggingdbRepository, LoggingdbRepository>();
            services.AddScoped<ITblLoggingRepository, TblLoggingRepository>();
            services.AddScoped<IAnalyticsRepository, AnalyticsRepository>();
            services.AddScoped<IQuickBookClientsRepository, QuickBookClientsRepository>();
            services.AddScoped<IClientMasterRepository,ClientMasterRepository>();
            services.AddScoped<IExcludedClientsRepository,ExcludedClientsRepository>();
            services.AddScoped<IApplicationSettingRepository,ApplicationSettingRepository>();
            //Services
            //services.AddInternalServices();

            services.AddScoped<IErrorLogService, ErrorLogService>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IFileNameService, FileNameService>();
            services.AddScoped<ITblLoggingService, TblLoggingService>();
            services.AddScoped<IAnalyticsService, AnalyticsService>();

            services.AddScoped<IQuickBookClientsServices,QuickBookClientsServices>();
            services.AddScoped<IClientMasterService,ClientMasterService>();
            services.AddScoped<IExcludedClientsService,ExcludedClientsService>();
            services.AddScoped<IApplicationSettingService, ApplicationSettingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            loggerFactory.AddFile("Logs/mylog-{Date}.txt");
        }
    }
}
