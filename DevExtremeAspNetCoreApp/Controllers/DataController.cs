using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp.Entities;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IInvoiceService _iInvoiceService;

        public DataController(IInvoiceService iInvoiceService)
        {
            _iInvoiceService = iInvoiceService;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {

            return _iInvoiceService.GetSampleDataForDashbard(loadOptions);
        }
    }
}
