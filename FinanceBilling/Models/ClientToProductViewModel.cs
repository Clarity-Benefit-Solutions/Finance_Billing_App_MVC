using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Models
{
    public class ClientToProductViewModel
    {
        public string SourceFileBencode { get; set; }
        public string SourceFileClientName { get; set; }
        public string? SourceFileProducts { get; set; }
        public string? BillingAppBenCode { get; set; }
        public string? BillingAppClientName { get; set; }
        public DateTime? StartBillingDate { get; set; }
        public DateTime? EndBillingDate { get; set; }
        public Int32 iNotExistInBillingAppTable { get; set; }

    }
}
