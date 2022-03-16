using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblQbImportsPro
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string InvoiceNumber { get; set; }
        public string BillingGroup { get; set; }
        public string EmployerKey { get; set; }
        public string EmployerName { get; set; }
        public string BillingCode { get; set; }
        public string BillingDescription { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Division { get; set; }
        public string ParticipantStatus { get; set; }
        public string ParticipantTermDate { get; set; }
        public int? PepmCount { get; set; }
        public decimal? PepmAmount { get; set; }
        public string OriginalEmployerName { get; set; }
    }
}
