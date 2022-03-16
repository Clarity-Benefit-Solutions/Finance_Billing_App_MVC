using DevExtreme.AspNet.Mvc;
using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IInvoiceService
    {
        Task<List<VwInvoiceByMonth>> GetSampleDataForDashbard();
        Task<object> GetSampleDataForDashbard(int month, int year);
    }
}
