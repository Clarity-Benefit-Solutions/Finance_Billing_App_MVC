using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IInvoiceService
    {
        Task<object> GetSampleDataForDashbard(DataSourceLoadOptions loadOptions);
        Task<object> GetSampleDataForDashbard(int month, int year);
    }
}
