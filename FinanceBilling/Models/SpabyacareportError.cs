using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class SpabyacareportError
    {
        public string? MemberId { get; set; }
        public string? ClientName { get; set; }
        public string? DivisionName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public DateTime? Dob { get; set; }
        public string? Ssn { get; set; }
        public string? IndividualIdentifier { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? StateOrProvince { get; set; }
        public string? Ein { get; set; }
        public string? PlanName { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public string? TobaccoUse { get; set; }
        public string? CarrierName { get; set; }
        public string? InsuranceType { get; set; }
        public string? CoverageLevelType { get; set; }
        public string? EmployeeType { get; set; }
        public string? RelationShipName { get; set; }
        public string? SpminsuranceTypePlanId { get; set; }
        public string? IsDependent { get; set; }
        public string? BillingTypeName { get; set; }
        public string? Status { get; set; }
        public DateTime? FirstDayOfCoverage { get; set; }
        public DateTime? LastDayOfCoverage { get; set; }
        public DateTime? TermDate { get; set; }
        public string? MyProperty { get; set; }
        public string? AccountTypeCode { get; set; }
        public string? ClientAlternate { get; set; }
        public string? UniqueKey { get; set; }
       
        public int? LoggingDbId { get; set; }

        public string? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public string? Description { get; set; }

    }
}
