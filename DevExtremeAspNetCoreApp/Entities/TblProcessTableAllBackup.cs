using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblProcessTableAllBackup
    {
        public string Process { get; set; }
        public string BillingGroup { get; set; }
        public string EmployerName { get; set; }
        public string EmployerKey { get; set; }
        public string EmployerBillingNumber { get; set; }
        public string SystemEmployerCode { get; set; }
        public string BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public string DivisionBillingKey { get; set; }
        public string Division { get; set; }
        public string ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountType { get; set; }
        public string PlanName { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public string ParticipantStatus { get; set; }
        public DateTime? ParticipantTermDate { get; set; }
        public string EnrollmentAmount { get; set; }
        public string ContributionAmount { get; set; }
        public string CoverageTier { get; set; }
        public string AllowClaimsImport { get; set; }
        public string UniqueKeyParticipant { get; set; }
        public string UniqueKeyBundleBilling { get; set; }
        public string UniqueKeyAccount { get; set; }
        public string UniqueKeyBillingAccount { get; set; }
        public string BillingCode { get; set; }
        public string QbBillingCode { get; set; }
        public string QbBillingCodeDescription { get; set; }
        public bool? PepmFlg { get; set; }
        public int? PepmCount { get; set; }
        public decimal? PepmAmount { get; set; }
        public string KeyMmMonthlyMinimum { get; set; }
        public bool? MonthlyMinimumFlg { get; set; }
        public decimal? MonthlyMinimumAmount { get; set; }
        public string BndBillingCode { get; set; }
        public bool? BndBundleBillFlg { get; set; }
        public decimal? BndBundleRateAmount { get; set; }
        public string BndBundleBillQual { get; set; }
        public bool? FlatRateFlg { get; set; }
        public decimal? FlatRateAmount { get; set; }
        public bool? PaidByBrokerFlg { get; set; }
        public int? PaidByBrokerPercent { get; set; }
        public bool? PaidByEmployerFlg { get; set; }
        public int? PaidByEmployerPercent { get; set; }
        public string CobraLetterType { get; set; }
        public bool? CobraPerNoticeFlg { get; set; }
        public decimal? CobraPerNoticeAmount { get; set; }
        public decimal? CobraNoticeBillAmount { get; set; }
        public int? CobraNoticeCount { get; set; }
        public int? CobraPepmCount { get; set; }
        public DateTime? LastBilledDate { get; set; }
        public string GeneralBillingCode { get; set; }
        public string GeneralKeyMm { get; set; }
        public bool? GeneralBillingFlg { get; set; }
        public int? GeneralBillingCount { get; set; }
        public decimal? GeneralBillingRate { get; set; }
        public decimal? GeneralBillingAmount { get; set; }
        public string BackupInvoiceNumber { get; set; }
        public string BillingGroupProcess { get; set; }
        public string OriginalEmployerName { get; set; }
        public int RowId { get; set; }
        public int? ToDelete { get; set; }
        public string DeleteReason { get; set; }
    }
}
