using AutoMapper;
using FinaceBilling.Custom.Dependency;
using FinaceBilling.Custom.Helpers;
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

namespace DevExtremeAspNetCoreApp
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
            //Repositories
            //services.AddInternalRepositories();
            services.AddTransient<IErrorLogsRepository, ErrorLogsRepository>();
            services.AddTransient<ICommonRepository, CommonRepository>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IFileNameRepository, FileNameRepository>();
            services.AddTransient<ITblLoggingRepository, TblLoggingRepository>();
            services.AddTransient<IAnalyticsRepository, AnalyticsRepository>();
            services.AddTransient<IQuickBookClientsRepository, QuickBookClientsRepository>();
            services.AddTransient<IClientMasterRepository,ClientMasterRepository>();
            services.AddTransient<IExcludedClientsRepository,ExcludedClientsRepository>();

            //Services
            //services.AddInternalServices();

            services.AddTransient<IErrorLogService, ErrorLogService>();
            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IFileNameService, FileNameService>();
            services.AddTransient<ITblLoggingService, TblLoggingService>();
            services.AddTransient<IAnalyticsService, AnalyticsService>();

            services.AddTransient<IQuickBookClientsServices,QuickBookClientsServices>();
            services.AddTransient<IClientMasterService,ClientMasterService>();
            services.AddTransient<IExcludedClientsService,ExcludedClientsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
