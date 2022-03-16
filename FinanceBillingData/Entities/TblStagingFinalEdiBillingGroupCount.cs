using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingFinalEdiBillingGroupCount
    {
        public string ClientName { get; set; }
        public string AlternateErId { get; set; }
        public int? NpmCount { get; set; }
        public int? TeCount { get; set; }
        public int? TpCount { get; set; }
        public int? FinalBillableCounts { get; set; }
        public string Suppress { get; set; }
    }
}
