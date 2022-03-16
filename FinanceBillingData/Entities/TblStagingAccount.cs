using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingAccount
    {
        public int Id { get; set; }
        public string EmployerCode { get; set; }
        public string DivisionBillingKey { get; set; }
        public string DivisionIbRecords { get; set; }
        public string RecordType { get; set; }
        public string AccountType { get; set; }
        public string EcAccountType { get; set; }
        public string TpaId { get; set; }
        public string PlanName { get; set; }
        public string ParticipantSsn { get; set; }
        public string EmployeeNumber { get; set; }
        public string PlanStartDateTxt { get; set; }
        public string PlanEndDateTxt { get; set; }
        public DateTime? PlanStartDateDt { get; set; }
        public DateTime? PlanEndDateDt { get; set; }
        public string EffectiveDateTxt { get; set; }
        public DateTime? EffectiveDateDt { get; set; }
        public string TerminationDateTxt { get; set; }
        public DateTime? TerminationDateDt { get; set; }
        public string ParticipantTermDateTxt { get; set; }
        public string AccountStatus { get; set; }
        public string ParticipantStatus { get; set; }
        public string ParticipantFirstName { get; set; }
        public string ParticipantLastName { get; set; }
        public decimal? OriginalPrefundedAnnualElectionAmount { get; set; }
        public decimal? ParticipantAnnualElection { get; set; }
        public decimal? ParticipantPayPeriodElection { get; set; }
        public decimal? EmployerAnnualElection { get; set; }
        public decimal? EmployerPayPeriodElection { get; set; }
        public bool? AutoClaimsPayFlg { get; set; }
        public string UniqueKeyParticipant { get; set; }
        public string UniqueKeyParticipantAccounts { get; set; }
        public int? PlanTermRunout { get; set; }
        public DateTime? TermDatePlusRunout { get; set; }
        public string TermBillableAccounts { get; set; }
        public string ProductPartnerStatus { get; set; }
        public string FutureEnrollmentExclude { get; set; }
    }
}
