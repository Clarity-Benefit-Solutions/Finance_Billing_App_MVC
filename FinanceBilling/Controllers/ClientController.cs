using AutoMapper;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp.Models;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Controllers
{
    public class ClientController : BaseController
    {

        private readonly IMapper _mapper;
        private readonly IClientService _iClientService;

        public ClientController(IMapper mapper, IClientService iClientService)
        {
            _iClientService = iClientService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> NewClient(DataSourceLoadOptions loadOptions)
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
                List<VwNewClient> vwNewClient = new List<VwNewClient>();
                vwNewClient = await _iClientService.GetNewClientList();
                _mapper.Map(vwNewClient, clientViewModels);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);

        }
        [HttpGet]
        public async Task<IActionResult> ExistingClient()
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
                List<VwExistingClient> vwExistingClients = new List<VwExistingClient>();
                vwExistingClients = await _iClientService.GetExistingClientList();
                _mapper.Map(vwExistingClients, clientViewModels);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> TerminatedClient()
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
                List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                vwTerminatedClients = await _iClientService.GetTerminatedClientList();

                _mapper.Map(vwTerminatedClients, clientViewModels);
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
        public JsonResult AddExcludedClient(string id)
        {
            try
            {
                TblExcludedClient tblExcludedClient = new TblExcludedClient();
                var result = _db.TblStagingClientsMasters.Where(x => x.ClientId == id && x.DivisionName != "0").FirstOrDefault();
                tblExcludedClient.ClientName = result.ClientName;
                tblExcludedClient.CreateDate = DateTime.Now;
                tblExcludedClient.Bencode = result.ClientAlternate;
                tblExcludedClient.ClientID = (int)Convert.ToInt64(result.ClientId);


                if (tblExcludedClient != null)
                {
                    _db.TblExcludedClients.Add(tblExcludedClient);
                    _db.SaveChanges();
                    return ReturnAjaxSuccessMessage("client added Succesfully");
                }
                else
                {
                return ReturnAjaxErrorMessage("client not added ");
                }
            }
            catch (Exception ex)
            {
                return ReturnAjaxErrorMessage(ex.Message);
            }     
        }
       
    }
}

