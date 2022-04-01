using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class PSP_GETLOGBYGUID
    {
        public long ID { get; set; }
        public string PackageName { get; set; }
        public string PackageID { get; set; }
        public string GUID { get; set; }
        public string MachineName { get; set; }
        public string? UserName { get; set; }
        public string? DataSource { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public int? NumRowsTotal { get; set; }
        public int? NumRowsInserted { get; set; }
        public int? NumRowsNotInserted { get; set; }
        
    }
}
