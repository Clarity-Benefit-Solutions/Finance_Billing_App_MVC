using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FinanceBillingModel.Models;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NLog.Fluent;

namespace FinanceBilling
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddleware
    {
        private readonly IConfiguration _config;
        private readonly RequestDelegate _next;
        private readonly IApplicationSettingService _iApplicationSettingService;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext, IConfiguration config, IApplicationSettingService iApplicationSettingService)
        {
            if (httpContext == null) throw new ArgumentNullException(nameof(httpContext));
            
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {

                var result = JsonConvert.SerializeObject(new { message = ex.Message });
                Log.Error("Exception Occured: " + result);
                if (ex.Message.Contains("because it is being used by another process")) { }
                else
                {
                    string uploadProcessName =config.GetSection("SSISTiming:UploadProcessName").Value;
                    // When proces is finished
                    await iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                    throw;
                }

                // httpContext.Response.ContentType = "application/json";
                //httpContext.Response.StatusCode = 500;
                // Error Logging into Logs table
                //context.Logs.Add(new Models.Logs { Message = exception.Message,MessageTemplate = result,Level="Exception",TimeStamp = DateTime.UtcNow,Exception= exception.InnerException.ToString(),UserId=userId  });

                //await httpContext.Response.WriteAsync(result);
            }


        }
    }
}
