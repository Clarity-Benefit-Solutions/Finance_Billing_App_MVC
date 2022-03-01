using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblBillingInvoiceExportAllQuickBook
    {
        public string BillingGroup { get; set; }
        public string EmployerName { get; set; }
        public string EmployerKey { get; set; }
        public string SystemEmployerKey { get; set; }
        public string BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public string BillingCode { get; set; }
        public string BillingCodeQb { get; set; }
        public string BillingDescription { get; set; }
        public decimal? BillingUnitCount { get; set; }
        public decimal? BillingUnitRate { get; set; }
        public decimal? BillingAmount { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public string Terms { get; set; }
        public string CustomerMessage { get; set; }
        public string BillingPeriod { get; set; }
        public string BillTo { get; set; }
        public bool? PaidByBrokerFlg { get; set; }
        public string KeyMmMonthlyMinimum { get; set; }
        public bool? MonthlyMinBillingFlg { get; set; }
        public decimal? MonthlyMinBillingAmount { get; set; }
        public decimal? CalculatedBillingAmount { get; set; }
        public string EmployerBillingNumber { get; set; }
        public string GlReceivableAccount { get; set; }
        public string GlExpenseAccount { get; set; }
        public string ToPrint { get; set; }
        public string ToEmail { get; set; }
        public bool? MonthlyMinToDelete { get; set; }
        public string OriginalEmployerName { get; set; }
        public string ProcessedGroup { get; set; }
        public int RowId { get; set; }
        public string BillingGroupProcess { get; set; }
        public int? RecordId { get; set; }
        public int ToDelete { get; set; }
        public string DeleteReason { get; set; }
    }
}
