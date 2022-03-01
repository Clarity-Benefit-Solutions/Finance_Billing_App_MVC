using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtremeAspNetCoreApp.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using DevExtremeAspNetCoreApp.Entities;

namespace DevExtremeAspNetCoreApp.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {
        private Finance_BillingContext _db;

        public SampleDataController(Finance_BillingContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            
            return DataSourceLoader.Load(_db.VwInvoiceByMonths.ToList(), loadOptions);
        }

        [HttpPost]
        public object PostData(string s)
        {

            return _db.VwInvoiceByMonths.Where(o=>o.Month==11 &&o.Year==2021).ToList();
        }
    }
}