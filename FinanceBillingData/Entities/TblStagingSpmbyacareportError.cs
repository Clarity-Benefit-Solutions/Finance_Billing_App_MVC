using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingSpmbyacareportError
    {
        public string MemberId { get; set; }
        public string ClientName { get; set; }
        public string DivisionName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Dob { get; set; }
        public string Ssn { get; set; }
        public string IndividualIdentifier { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string Ein { get; set; }
        public string PlanName { get; set; }
        public string PlanStartDate { get; set; }
        public string PlanEndDate { get; set; }
        public string TobaccoUse { get; set; }
        public string CarrierName { get; set; }
        public string InsuranceType { get; set; }
        public string CoverageLevelType { get; set; }
        public string EmployeeType { get; set; }
        public string RelationShipName { get; set; }
        public string SpminsuranceTypePlanId { get; set; }
        public string IsDependent { get; set; }
        public string BillingTypeName { get; set; }
        public string Status { get; set; }
        public string FirstDayOfCoverage { get; set; }
        public string LastDayOfCoverage { get; set; }
        public string TermDate { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
