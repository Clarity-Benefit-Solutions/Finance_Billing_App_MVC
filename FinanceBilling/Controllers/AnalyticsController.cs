using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using FinaceBilling.Models;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Controllers
{
    public class AnalyticsController : Controller
    {
        public readonly IAnalyticsService _analyticsService;
        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListClientProductComparison(DataSourceLoadOptions loadOptions)
        {
            List<ClientToProductViewModel> clientToProductViewModels = new List<ClientToProductViewModel>();
            try
            {
                //List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                //vwTerminatedClients = await _iClientService.GetTerminatedClientList();
                //_mapper.Map(vwTerminatedClients, clientViewModels);
                var result = DataSourceLoader.Load(await _analyticsService.GetListClientProductComparison(1000000000, 0), loadOptions);
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientToProductViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> GetListClientToClientComparison(DataSourceLoadOptions loadOptions)
        {
            List<ClientToClientViewModel> clientToClientViewModels = new List<ClientToClientViewModel>();
            try
            {
                //List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                //vwTerminatedClients = await _iClientService.GetTerminatedClientList();
                //_mapper.Map(vwTerminatedClients, clientViewModels);
                var result = DataSourceLoader.Load(await _analyticsService.GetListClientToClientComparison(1000000000, 0), loadOptions);
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientToClientViewModels);
        }
    }
}
