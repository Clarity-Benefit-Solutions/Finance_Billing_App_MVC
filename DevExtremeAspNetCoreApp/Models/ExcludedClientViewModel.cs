using DevExtremeAspNetCoreApp.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp.Models
{
    public class ExcludedClientViewModel
    {
        public List<SpClientDropDownData> SpClientDropDownData { get; set; }
        public List<SpExcludeClientData> spExcludeClientDatas { get; set; }

  //      public int ClientID { get; set; }
		//public string ClientName { get; set; }
		//public string Bencode { get; set; }
		//public string Description { get; set; }
		//public string UserID { get; set; }
		//public string UserName { get; set; }
		//public DateTime CreateDate { get; set; }
    }
}
