using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class ErrorLogService : IErrorLogService
    {
        private readonly IErrorLogsRepository _iErrorLogsRepository;
        private readonly ITblLoggingService _iTblLoggingService;

        public ErrorLogService(IErrorLogsRepository iErrorLogsRepository, ITblLoggingService iTblLoggingService)
        {
            _iErrorLogsRepository = iErrorLogsRepository;
            _iTblLoggingService=iTblLoggingService;
        }
        public async Task<List<TblErrorLog>> GetErrorLogs()
        {
            return await _iErrorLogsRepository.GetErrorLogs();
        }

        public async Task<List<TBLERRORLOGS>> GetErrorLogsByLogId(int logId)
        {
            return await _iErrorLogsRepository.GetErrorLogsByLogId(logId);
        }
        public async Task<List<TBLERRORLOGS>> GetErrorLogsByGuId(string guid)
        {
            TblLogging tblLogging= await _iTblLoggingService.GetTblLoggingByGUID(guid);
            if (tblLogging != null)
            {
                return await _iErrorLogsRepository.GetErrorLogsByLogId(tblLogging.Id);
            }
            else {
                return null;

            }
        }
    }
}
