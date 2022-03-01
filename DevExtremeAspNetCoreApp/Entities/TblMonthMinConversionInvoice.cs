using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblMonthMinConversionInvoice
    {
        public bool? Process { get; set; }
        public string EmployerName { get; set; }
        public string EmployerKey { get; set; }
        public string BillingGroup { get; set; }
        public string SystemEmployerCode { get; set; }
        public string BrokerCode { get; set; }
        public string EmployerBillingNumber { get; set; }
        public string AccountType { get; set; }
        public string PlanName { get; set; }
        public string KeyMmMonthlyMinimum { get; set; }
        public string BillingCode { get; set; }
        public string MonthlyMinBillingCode { get; set; }
        public string BillingDescription { get; set; }
        public bool? MonthlyMinimumFlg { get; set; }
        public string BillingUnitCount { get; set; }
        public decimal? BillingUniteRate { get; set; }
        public decimal? MonthlyMinimumAmount { get; set; }
        public decimal? FinalInvoiceAmount { get; set; }
        public decimal? BilledAmountMonthlyMinDiff { get; set; }
        public bool? MonthlyMinGreater { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
