using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class SwiftBillingNumImportError
    {
        //public string? GroupNumber { get; set; }
        //public string? ClientName { get; set; }
        //public DateTime? ClientEffectiveDate { get; set; }
        //public string? Division { get; set; }
        //public string? Location { get; set; }
        //public string? EmployeeId { get; set; }
        //public string? LastName { get; set; }
        //public string? FirstName { get; set; }
        //public string? BenefitClassName { get; set; }
        //public string? BenefitClassBenefitEligible { get; set; }
        //public string? ParticipantUniqueKey { get; set; }
        //public string? ErrorCode { get; set; }
        //public string? ErrorColumn { get; set; }
        //public long? LoggingDbId { get; set; }
        //public string? Description { get; set; }
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }

    }
}
