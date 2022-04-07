using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class ClientListError
    {
        //public string? ClientGroupName { get; set; }
        //public string? ClientName { get; set; }
        //public string? BillingStartDate { get; set; }
        //public string? EIN { get; set; }
        //public string? ClientDivisionName { get; set; }
        //public string? ClientID { get; set; }
        //public string? ClientDivisionID { get; set; }
        //public string? Active { get; set; }
        //public string? ClientAlternate { get; set; }
        //public string? DeactivationDate { get; set; }
        //public string? DivisionName { get; set; }
        //public string? ErrorCode { get; set; }
        //public string? ErrorColumn { get; set; }
        //public long? LoggingDbId { get; set; }
        //public string? Description { get; set; }
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }


    }
}
