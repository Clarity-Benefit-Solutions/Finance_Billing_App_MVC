using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblEdiBillingGroupCount
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
