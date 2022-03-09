using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IErrorLogService
    {
        Task<List<TblErrorLog>> GetErrorLogs();
    }
}
