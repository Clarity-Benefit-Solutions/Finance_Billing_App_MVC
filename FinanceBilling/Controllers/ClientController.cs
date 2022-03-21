using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using FinanceBilling.Models;
using FinanceBilling.Models;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceBilling.Controllers
{
    public class ClientController : BaseController
    {

        private readonly IMapper _mapper;
        private readonly IClientService _iClientService;
        private readonly IExcludedClientsService _iExcludedClientsService;
        public ClientController(IMapper mapper, IClientService iClientService, IExcludedClientsService iExcludedClientsService)
        {
            _iClientService = iClientService;
            _iExcludedClientsService = iExcludedClientsService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> NewClient(DataSourceLoadOptions loadOptions)
        {
            List<NewClientViewModel> clientViewModels = new List<NewClientViewModel>();
            try
            {
                //List<VwNewClient> vwNewClient = new List<VwNewClient>();
                var result = DataSourceLoader.Load(await _iClientService.GetNewClientList(1000000000, 0), loadOptions);
                //var result = await _iClientService.GetNewClientList();
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");
                //_mapper.Map(vwNewClient, clientViewModels);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);

        }
        [HttpGet]
        public async Task<IActionResult> ExistingClient(DataSourceLoadOptions loadOptions)
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
                //List<VwExistingClient> vwExistingClients = new List<VwExistingClient>();
                //vwExistingClients = await _iClientService.GetExistingClientList();
                //_mapper.Map(vwExistingClients, clientViewModels);
                 var result = DataSourceLoader.Load(await _iClientService.GetExistingClientList(1000000000, 0), loadOptions);
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> TerminatedClient(DataSourceLoadOptions loadOptions)
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
                List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                //vwTerminatedClients = await _iClientService.GetTerminatedClientList();
                //_mapper.Map(vwTerminatedClients, clientViewModels);
                var result = DataSourceLoader.Load(await _iClientService.GetTerminatedClientList(1000000000, 0), loadOptions);
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> ExcludedClient()
        {
            ExcludedClientViewModel excludedClientViewModels = new ExcludedClientViewModel();
            try
            {
                excludedClientViewModels.SpClientDropDownData = new List<SpClientDropDownData>();
                excludedClientViewModels.spExcludeClientDatas = new List<SpExcludeClientData>();

                excludedClientViewModels.SpClientDropDownData = await _iClientService.GetClientDropDownData();
                excludedClientViewModels.spExcludeClientDatas = await _iClientService.GetExcludeClientDataList();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(excludedClientViewModels);
        }
        [HttpGet]
        public async Task<JsonResult> AddExcludedClient(string clientId)
        {
            try
            {
                bool isSuccess = await _iExcludedClientsService.AddExcludedClientFromMasterClient(clientId);
                if (isSuccess)
                {
                    return Json(new { success = false, responseText = "client added Succesfully." });
                }
                else
                {
                    return Json(new { success = false, responseText = "client not added." });
                }
            }
           
           
            
            //try
            //{
            //    TblExcludedClient tblExcludedClient = new TblExcludedClient();
            //    TblStagingClientsMaster tblStagingClientsMaster = await _iClientService.GetTblStagingClientById(clientId);
            //    tblExcludedClient.ClientName = tblStagingClientsMaster.ClientName;
            //    tblExcludedClient.CreateDate = DateTime.Now;
            //    tblExcludedClient.Bencode = tblStagingClientsMaster.ClientAlternate;
            //    tblExcludedClient.ClientID = (int)Convert.ToInt64(tblStagingClientsMaster.ClientId);
                



            //    if (tblExcludedClient != null)
            //    {
            //         await _iClientService.AddTblExcludeClient(tblExcludedClient);
            //            return ReturnAjaxSuccessMessage("client added Succesfully");
            //    }
                
            //    return    ReturnAjaxErrorMessage("Something Went Wrong ");
                
            //}
            catch (Exception ex)
            {
                return ReturnAjaxErrorMessage(ex.Message);
            }     
        }
        [HttpDelete]
        public async Task DeleteExculdedClient(int Key)
        {
            //try
            //{

            await _iExcludedClientsService.DeleteExculdedClient(Key);

            //return RedirectToAction("ExcludedClient");
            //    }
            //    catch (Exception ex)
            //    {

            //        return ex.Message;
            //    }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllExcludedClient(DataSourceLoadOptions loadOptions)
        {
            List<TblExcludedClient> tblExcludedClients = new List<TblExcludedClient>();
            try
            {
                List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                //vwTerminatedClients = await _iClientService.GetTerminatedClientList();
                //_mapper.Map(vwTerminatedClients, clientViewModels);
                var result = DataSourceLoader.Load(await _iExcludedClientsService.GetAllExcludedClient(1000000000, 0), loadOptions);
                var resultJson = JsonConvert.SerializeObject(result);
                return Content(resultJson, "application/json");

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(tblExcludedClients);
        }

    }
}

