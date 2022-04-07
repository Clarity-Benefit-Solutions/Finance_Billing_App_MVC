using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class ErrorFileNameList
    {
        public int ID { get; set; }
        public String PackageName { get; set; }
        public String PackageId { get; set; }
        public String GUID { get; set; }
        public String MachineName { get; set; }
        public String UserName { get; set; }
        public String DataSource { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int NumRowsTotal { get; set; }
        public int NumRowsInserted { get; set; }
        public int NumRowsNotInserted { get; set; }
    }
}
