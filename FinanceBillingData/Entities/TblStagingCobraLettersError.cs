using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingCobraLettersError
    {
        public string ClientName { get; set; }
        public string DivisionName { get; set; }
        public string ModeOrder { get; set; }
        public string ModeName { get; set; }
        public string Description { get; set; }
        public long? Qty { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
