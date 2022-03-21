using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class ErrorLogsRepository : IErrorLogsRepository
    {
        private Finance_BillingContext _db;
        public ErrorLogsRepository(Finance_BillingContext db)
        {
            _db = db;
        }
        public async Task<List<TblErrorLog>> GetErrorLogs()
        {
            return await Task.Run(() =>
            {
                return _db.TblErrorLogs.ToList();
            });
        }
        public async Task<List<TBLERRORLOGS>> GetErrorLogsByLogId(long logId)
        {
            return await Task.Run(() =>
            {
                return _db.TBLERRORLOGSs.AsQueryable().Where(x=>x.LoggingDbID== logId).ToList();
            });
        }

    }
}
