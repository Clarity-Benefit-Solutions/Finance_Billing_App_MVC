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
        public async Task<List<TblLogging>> ExecuteSSISPackage(string guid)
        {
            int intervalTime = Convert.ToInt32(_config.GetSection("SSISTiming:TotalInterval").Value);
            int sleepTime = Convert.ToInt32(_config.GetSection("SSISTiming:SleepTime").Value);
            string parentPackageName = _config.GetSection("SSISTiming:ParentPackageName").Value;

            await _iCommonRepository.ExecuteSSISPackage(guid);
            DateTime currentTime = DateTime.Now;
            DateTime MinsLater = currentTime.AddMinutes(intervalTime);
            List<TblLogging> tblLoggingList = new List<TblLogging>();
            TblLogging tblLogging = new TblLogging();
            await Task.Delay(1000 * sleepTime / 2);
            do
            {
                currentTime = DateTime.Now;
                await Task.Delay(10000 * sleepTime);
                tblLoggingList = await _tblLoggingRepository.GetStatusById(guid);
                // var test = await _tblLoggingRepository.GetStatusById((int)data.Id);
                TblLogging parentFile = tblLoggingList.Where(x => x.PackageName == parentPackageName).FirstOrDefault();
                if (parentFile != null)
                {
                    if (parentFile.IsCompleted == true)
                    {
                        tblLogging = parentFile;
                        break;
                    }
                }
                 
            } while (currentTime <= MinsLater);

            return tblLoggingList;
        }
    }
}
