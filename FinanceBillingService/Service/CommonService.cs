using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class CommonService : ICommonService
    {
        private readonly IConfiguration _config;
        private readonly ITblLoggingRepository _tblLoggingRepository;
        private readonly ICommonRepository _iCommonRepository;
        public CommonService(ICommonRepository iCommonRepository, IConfiguration config, ITblLoggingRepository tblLoggingRepository)
        {
            _iCommonRepository = iCommonRepository;
            _config = config;
            _tblLoggingRepository = tblLoggingRepository;
        }
        public async Task<bool> ExecuteSSISPackage(string guid)
        {
            int intervalTime = Convert.ToInt32(_config.GetSection("SSISTiming:TotalInterval").Value);
            int sleepTime = Convert.ToInt32(_config.GetSection("SSISTiming:SleepTime").Value);

            await _iCommonRepository.ExecuteSSISPackage(guid);
            DateTime currentTime = DateTime.Now;
            DateTime MinsLater = currentTime.AddMinutes(intervalTime);
            TblLogging tblLogging = new TblLogging();
            await Task.Delay(10000 * sleepTime / 2);
            do
            {
                await Task.Delay(1000 * sleepTime);
                var data = await _tblLoggingRepository.GetTblLoggingByGUID(guid);
                if (data.IsCompleted == true)
                {
                    tblLogging = data;
                    break;
                }

            } while (currentTime <= MinsLater);

            if (tblLogging.IsSuccess == true)
            {
                return true;
            }
            else
            {
                return false;
                //ViewBag.Message = "File Uploaded Successfully";
            }
        }
    }
}
