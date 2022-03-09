using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private Finance_BillingContext _db;
        public InvoiceRepository(Finance_BillingContext db)
        {
            _db = db;
        }


        public async Task<List<VwInvoiceByMonth>> GetSampleDataForDashbard()
        {
            return _db.VwInvoiceByMonths.ToList();
            //return await Task.Run<List<VwInvoiceByMonth>>(() => {
            //    List<VwInvoiceByMonth> result= _db.VwInvoiceByMonths.ToList();
            //    return result;
            //});
                
        }
        public async Task<List<VwInvoiceByMonth>> GetInvoiceDataByMonth(int month,int year)
        {
            return _db.VwInvoiceByMonths.Where(o => o.Month == month && o.Year == year).ToList();
            //return await Task.Run<List<VwInvoiceByMonth>>(() => {
            //    return _db.VwInvoiceByMonths.Where(o => o.Month == month && o.Year == year).ToList();
            //});

        }
        
    }
}
