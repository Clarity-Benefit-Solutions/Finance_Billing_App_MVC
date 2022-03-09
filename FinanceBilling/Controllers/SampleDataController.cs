using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtremeAspNetCoreApp.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using FinanceBillingService.Interface;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        private IInvoiceService _iInvoiceService;
        public SampleDataController(IInvoiceService iInvoiceService)
        {
            _iInvoiceService = iInvoiceService;
        }

        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions) {

            return DataSourceLoader.Load(await _iInvoiceService.GetSampleDataForDashbard(), loadOptions);
        }

        [HttpPost]
        public object PostData(string s)
        {
            int month = 11; int year = 2021;
            return _iInvoiceService.GetSampleDataForDashbard( month, year);
        }
    }
}