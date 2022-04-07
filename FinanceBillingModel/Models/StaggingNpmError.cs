using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class StaggingNpmError
    {
        //public string? ClientName { get; set; }
        //public string? include { get; set; }
        //public string? DivisionName { get; set; }
        //public string? FullName { get; set; }
        //public string? SSN { get; set; }
        //public string? CoverageLevel { get; set; }
        //public string? Address { get; set; }
        //public string? Address2 { get; set; }
        //public string? City { get; set; }
        //public string? StateOrProvince { get; set; }
        //public string? PostalCode { get; set; }
        //public string? Country { get; set; }
        //public DateTime? PDFGeneratedDateTime { get; set; }
        //public string? IndividualIdentifier { get; set; }
        //public string? Type { get; set; }
        //public string? MemberID { get; set; }
        //public string? IsPaylocity { get; set; }
        //public string? AlternateERID { get; set; }
        //public int? ErrorCode { get; set; }
        //public string? ErrorColumn { get; set; }
        //public int? LoggingDbId { get; set; }
        //public string? Description { get; set; }
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }

    }
}
