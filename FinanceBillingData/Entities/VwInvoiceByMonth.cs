using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class VwInvoiceByMonth
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string EmployerName { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public int? InvoiceCount { get; set; }
    }
}
