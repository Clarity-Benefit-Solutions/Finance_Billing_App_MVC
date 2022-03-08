using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class InvoiceService : IInvoiceService

    {
        private IInvoiceRepository _iInvoiceRepository;
        public InvoiceService(IInvoiceRepository iInvoiceRepository)
        {

            _iInvoiceRepository = iInvoiceRepository;
        }
        public async Task<object> GetSampleDataForDashbard(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(await _iInvoiceRepository.GetSampleDataForDashbard(), loadOptions);
        }
        public async Task<object> GetSampleDataForDashbard(int month, int year)
        {
            return await _iInvoiceRepository.GetInvoiceDataByMonth(month, year);
        }
    }
}
