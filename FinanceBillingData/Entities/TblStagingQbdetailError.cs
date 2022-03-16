using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingQbdetailError
    {
        public double? MemberId { get; set; }
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
        public double? PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public double? Ein { get; set; }
        public string PlanName { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public string TobaccoUse { get; set; }
        public string CarrierName { get; set; }
        public string InsuranceType { get; set; }
        public string CoverageLevelType { get; set; }
        public string EmployeeType { get; set; }
        public string RelationShipName { get; set; }
        public string IsDependent { get; set; }
        public DateTime? SpecificRightsProcessedDate { get; set; }
        public string EventType { get; set; }
        public string EventCategory { get; set; }
        public DateTime? QualifyingEventDate { get; set; }
        public bool? UsesHealthCoverageTaxCredit { get; set; }
        public string Status { get; set; }
        public DateTime? FirstDayOfCobra { get; set; }
        public DateTime? LastDayOfCobra { get; set; }
        public DateTime? TermDate { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
