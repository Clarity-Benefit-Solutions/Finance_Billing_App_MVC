using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStatingEcExtract
    {
        public string RecordType { get; set; }
        public string TpaId { get; set; }
        public string EmployerId { get; set; }
        public string AccountTypeCode { get; set; }
        public string PlanId { get; set; }
        public string EmployeeSocialSecurityNumber { get; set; }
        public string EmployeeId { get; set; }
        public string DependentId { get; set; }
        public string PlanStartDate { get; set; }
        public string PlanEndDate { get; set; }
        public string EffectiveDate { get; set; }
        public string TerminationDate { get; set; }
        public string AccountStatus { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string CurrentAnnualElection { get; set; }
        public string OriginalPrefundedAnnualElectionAmount { get; set; }
        public string IndividualAmount { get; set; }
        public string EmployeeAnnualElection { get; set; }
        public string EmployeePayPeriodElection { get; set; }
        public string EmployerAnnualElection { get; set; }
        public string EmployerPayPeriodElection { get; set; }
        public string EmployeeContributionYtd { get; set; }
        public string EmployerContributionYtd { get; set; }
        public string OtherDeposits { get; set; }
        public string DisbursementsPtd { get; set; }
        public string DisbursableBalance { get; set; }
        public string AvailableBalance { get; set; }
        public string AutoReimbursementSetting { get; set; }
        public string StartAutoDepositDate { get; set; }
        public string AutoDepositCalendarId { get; set; }
        public string CardNumber { get; set; }
        public string CoverageTierId { get; set; }
        public string EmployeeAddress1 { get; set; }
        public string EmployeeAddress2 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeZip { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public string EmployeeBirthDate { get; set; }
        public string ProductPartnerAcctStatus { get; set; }
        public string ProductPartnerAcctCloseDate { get; set; }
        public string UniqueKeyAccounts { get; set; }
        public string BillableAccount { get; set; }
        public string UniqueKeyPerpay { get; set; }
        public string EbTermDate { get; set; }
        public string EbTermStatus { get; set; }
    }
}
