using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingEdi3SourceDatum
    {
        public string Client { get; set; }
        public string Bencode { get; set; }
        public string NpmCount { get; set; }
        public string TeCount { get; set; }
        public string TpCount { get; set; }
        public double? NewQty { get; set; }
        public int? OriginalCalcultated { get; set; }
        public int? PriorBilledNumber { get; set; }
        public string ErControlBillingCode { get; set; }
        public double? OldQty { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
