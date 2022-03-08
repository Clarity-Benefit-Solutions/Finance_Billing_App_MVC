﻿using AutoMapper;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinaceBilling.Controllers
{
    public class ClientController : Controller
    {
        
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper)
        {
            
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
       
    }
}

