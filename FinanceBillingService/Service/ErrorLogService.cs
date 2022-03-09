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

        public ErrorLogService(IErrorLogsRepository iErrorLogsRepository)
        {
            _iErrorLogsRepository = iErrorLogsRepository;
        }
        public async Task<List<TblErrorLog>> GetErrorLogs()
        {
            return await _iErrorLogsRepository.GetErrorLogs();
        }
    }
}
