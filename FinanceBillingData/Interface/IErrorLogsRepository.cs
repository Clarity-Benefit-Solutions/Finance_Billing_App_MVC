using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IErrorLogsRepository
    {
        Task<List<TblErrorLog>> GetErrorLogs();
    }
}
