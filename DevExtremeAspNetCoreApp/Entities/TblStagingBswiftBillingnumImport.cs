using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingBswiftBillingnumImport
    {
        public string GroupNumber { get; set; }
        public string ClientName { get; set; }
        public DateTime? ClientEffectiveDate { get; set; }
        public string Division { get; set; }
        public string Location { get; set; }
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BenefitClassName { get; set; }
        public string BenefitClassBenefitEligible { get; set; }
        public string ParticipantUniqueKey { get; set; }
    }
}
