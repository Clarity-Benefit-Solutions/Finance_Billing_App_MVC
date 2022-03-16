using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IInvoiceRepository
    {
        Task<List<VwInvoiceByMonth>> GetSampleDataForDashbard();
        Task<List<VwInvoiceByMonth>> GetInvoiceDataByMonth(int month, int year);
    }
}
