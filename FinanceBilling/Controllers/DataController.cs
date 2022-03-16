using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<object> Get(DataSourceLoadOptions loadOptions)
        {

            return DataSourceLoader.Load(await _iInvoiceService.GetSampleDataForDashbard(), loadOptions);
        }
    }
}
