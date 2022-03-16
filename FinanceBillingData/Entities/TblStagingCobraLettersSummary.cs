using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingCobraLettersSummary
    {
        public string ClientName { get; set; }
        public string DivisionName { get; set; }
        public string ModeOrder { get; set; }
        public string ModeName { get; set; }
        public string Description { get; set; }
        public string Qty { get; set; }
        public string ClientCode { get; set; }
    }
}
