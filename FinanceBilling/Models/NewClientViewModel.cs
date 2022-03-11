using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Models
{
    public class NewClientViewModel
    {
        public string ClientGroupName { get; set; }
        public string ClientName { get; set; }
        public string BillingStartDate { get; set; }
        public string EIN { get; set; }
        public string ClientDivisionName { get; set; }
        public string ClientID { get; set; }
        public string ClientDivisionID { get; set; }
        public string Active { get; set; }
        public string ClientAlternate { get; set; }
        public string DeactivationDate { get; set; }
        public string TPACode { get; set; }
        public string Linetype { get; set; }
        public string AccountTypeCode { get; set; }
        public string DivisionName { get; set; }
        public string PlanID { get; set; }
    }
}
