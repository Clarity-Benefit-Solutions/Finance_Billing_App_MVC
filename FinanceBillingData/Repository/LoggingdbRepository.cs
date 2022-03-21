using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class LoggingdbRepository: ILoggingdbRepository
    {
        private Finance_BillingContext _db;
        public LoggingdbRepository(Finance_BillingContext db)
        {
            _db = db;
        }

        public async Task<List<TblLogging>> GetLoggingdbList()
        {
            return await Task.Run(() => {
                return _db.TblLoggings.ToList();
            });
        }
        public async Task<List<TBLERRORLOGS>> GeterrorsList()
        {
            return await Task.Run(() => {
                return _db.TBLERRORLOGSs.ToList();
            });
        }
    }

    
}
