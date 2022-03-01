using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingBrokerclientlistError
    {
        public string BrokerId { get; set; }
        public string BrokerName { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAlternate { get; set; }
        public string Ein { get; set; }
        public string BillingStartDate { get; set; }
        public string Active { get; set; }
        public string ClientDivisionId { get; set; }
        public string ClientDivisionName { get; set; }
        public string DivisionName { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
