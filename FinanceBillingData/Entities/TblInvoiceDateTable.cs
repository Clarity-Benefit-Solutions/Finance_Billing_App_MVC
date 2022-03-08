using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblInvoiceDateTable
    {
        public DateTime BillingDateMonth { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public DateTime? EnrollmentMaxEffexctiveDt { get; set; }
        public string BillingPeriod { get; set; }
        public string InvoiceCustomerMessage { get; set; }
        public string InvoiceTerms { get; set; }
        public string ToPrint { get; set; }
        public string ToEmail { get; set; }
        public string BillingPeriodToCompare { get; set; }
        public int? Id { get; set; }
        public DateTime? BillingRunoutDate { get; set; }
    }
}
