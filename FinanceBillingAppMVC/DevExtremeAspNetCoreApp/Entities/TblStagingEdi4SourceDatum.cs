using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingEdi4SourceDatum
    {
        public string RecordType { get; set; }
        public string EmployerId { get; set; }
        public string EmployeeId { get; set; }
        public string DependentId { get; set; }
        public string CardEffectiveDate { get; set; }
        public string CardExpireDate { get; set; }
        public string PrimaryCard { get; set; }
        public string StatusCode { get; set; }
        public string StatusCodeReason { get; set; }
        public string ActivationDate { get; set; }
        public string MailedDate { get; set; }
        public string IssueDate { get; set; }
        public string IssuedBy { get; set; }
        public string CreationDate { get; set; }
        public string LastUpdated { get; set; }
        public DateTime? CreateDateDate { get; set; }
    }
}
