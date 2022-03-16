using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Models
{
    public class StagingClientViewModel
    {
        public string ClientGroupName { get; set; }
        public string ClientName { get; set; }
        public string BillingStartDate { get; set; }
        public string Ein { get; set; }
        public string ClientDivisionName { get; set; }
        public string ClientId { get; set; }
        public string ClientDivisionId { get; set; }
        public string Active { get; set; }
        public string ClientAlternate { get; set; }
        public string DeactivationDate { get; set; }
        public string DivisionName { get; set; }
    }
}
