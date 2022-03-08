using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingNpnCount
    {
        public string ClientName { get; set; }
        public string AlternateErId { get; set; }
        public int? CountOfSsn { get; set; }
    }
}
