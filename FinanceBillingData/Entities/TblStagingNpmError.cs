using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingNpmError
    {
        public string ClientName { get; set; }
        public string DivisionName { get; set; }
        public string FullName { get; set; }
        public string Ssn { get; set; }
        public string CoverageLevel { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PdfgeneratedDateTime { get; set; }
        public string IndividualIdentifier { get; set; }
        public string Type { get; set; }
        public string MemberId { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
