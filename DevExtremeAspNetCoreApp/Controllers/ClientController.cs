using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp.Entities;
using DevExtremeAspNetCoreApp.Models;
using FinaceBilling.Entities;
using FinaceBilling.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinaceBilling.Controllers
{
    public class ClientController : BaseController
    {
        private Finance_BillingContext _db;
        private readonly IMapper _mapper;

        public ClientController(Finance_BillingContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult NewClient(DataSourceLoadOptions loadOptions)
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();

            try
            {
            List<VwNewClient> vwNewClient = new List<VwNewClient>();
                 vwNewClient = _db.VwNewClient.ToList();
                _mapper.Map(vwNewClient, clientViewModels);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
           
        }
        [HttpGet]
        public IActionResult ExistingClient()
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
            List<VwExistingClient> vwExistingClients = new List<VwExistingClient>();
                vwExistingClients = _db.VwExistingClient.ToList();
                _mapper.Map(vwExistingClients, clientViewModels);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
        }
        [HttpGet]
        public IActionResult TerminatedClient()
        {
            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
            try
            {
            List<VwTerminatedClient> vwTerminatedClients = new List<VwTerminatedClient>();
                vwTerminatedClients = _db.VwTerminatedClient.ToList();
                _mapper.Map(vwTerminatedClients, clientViewModels);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(clientViewModels);
        }
        [HttpGet]
        public IActionResult ExcludedClient()
        {
            ExcludedClientViewModel excludedClientViewModels = new ExcludedClientViewModel();
            try
            {
                excludedClientViewModels.SpClientDropDownData = new List<SpClientDropDownData>(); 
                excludedClientViewModels.spExcludeClientDatas = new List<SpExcludeClientData>();

                excludedClientViewModels.SpClientDropDownData = _db.SpClientDropDownData.FromSqlRaw("SPS_GET_CLIENTDROPDOWNDATA").ToList();
                excludedClientViewModels.spExcludeClientDatas= _db.SpExcludeClientData.FromSqlRaw("SPS_GET_EXCLUDECLIENTDATA").ToList();
                
               
                
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

