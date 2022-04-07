using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class ErrorFileData
    {
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }


    }
}
