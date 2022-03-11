using AutoMapper;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp.Models;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
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
        public async Task<JsonResult> AddExcludedClient(string clientId)
        {
            try
            {
                TblExcludedClient tblExcludedClient = new TblExcludedClient();
                TblStagingClientsMaster tblStagingClientsMaster = await _iClientService.GetTblStagingClientById(clientId);
                tblExcludedClient.ClientName = tblStagingClientsMaster.ClientName;
                tblExcludedClient.CreateDate = DateTime.Now;
                tblExcludedClient.Bencode = tblStagingClientsMaster.ClientAlternate;
                tblExcludedClient.ClientID = (int)Convert.ToInt64(tblStagingClientsMaster.ClientId);
                



                if (tblExcludedClient != null)
                {
                     await _iClientService.AddTblExcludeClient(tblExcludedClient);
                        return ReturnAjaxSuccessMessage("client added Succesfully");
                }
                
                return    ReturnAjaxErrorMessage("Something Went Wrong ");
                
            }
            catch (Exception ex)
            {
                return ReturnAjaxErrorMessage(ex.Message);
            }     
        }
        [HttpGet]
        public async Task<IActionResult> DeleteExculdedClient(int id)
        {
            try
            {
                //TblExcludedClient tblExcludedClient = new TblExcludedClient();
                //tblExcludedClient = _db.TblExcludedClients.Where(x => x.Id == id).FirstOrDefault();
                //tblExcludedClient =
                    await _iClientService.DeleteExculdedClient( id);
                //tblExcludedClient.isDeleted = true;

                //if (tblExcludedClient != null)
                //{
                //    _db.TblExcludedClients.Update(tblExcludedClient);
                //    _db.SaveChanges();
                //}
                return RedirectToAction("ExcludedClient");
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }

    }
}

