using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public partial class ClientToClientComparison
    {
        public string SourceFileBenCode { get; set; }
        public string SourceFileClientName { get; set; }
        public string? BillingAppBenCode { get; set; }
        public string? BillingAppClientName { get; set; }
        public DateTime? EndBillingDate { get; set; }
        public DateTime? StartBillingDate { get; set; }
        public Int32 iNotExistInBillingAppTable { get; set; }
        
            
    }
}
