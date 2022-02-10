using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblBkRptExport
    {
        public string BillingGroup { get; set; }
        public string EmployerKey { get; set; }
        public string EmployerName { get; set; }
        public string Division { get; set; }
        public string BackupInvoiceNumber { get; set; }
        public string BillingCode { get; set; }
        public string BillingDescription { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ParticipantStatus { get; set; }
        public DateTime? ParticipantTermDate { get; set; }
        public string Pepm { get; set; }
        public decimal? PepmAmount { get; set; }
        public string OriginalEmployerName { get; set; }
        public int? RowId { get; set; }
        public int? ToDelete { get; set; }
        public string DeleteReason { get; set; }
        public int? PepmFlg { get; set; }
        public string BndBillingCode { get; set; }
        public string ActualBillingCode { get; set; }
        public string BillingGroupProcess { get; set; }
        public string UniqueKeyParticipant { get; set; }
    }
}
