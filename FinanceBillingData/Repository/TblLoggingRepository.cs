using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class TblLoggingRepository: ITblLoggingRepository
    {
        private Finance_BillingContext _db;
        public TblLoggingRepository(Finance_BillingContext db)
        {
            _db = db;
        }
        public async Task<TblLogging> GetTblLoggingByGUID(string guid)
        {
            return await Task.Run<TblLogging>(() => {
                TblLogging tblLogging = new TblLogging();
               return  tblLogging = _db.TblLoggings.Where(c => c.Guid == guid).FirstOrDefault();
            });
        }
    }
}
