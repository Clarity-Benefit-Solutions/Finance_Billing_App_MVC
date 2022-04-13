using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class LogsByGuid
    {
        public Int64 Id { get; set; }
        public string? PackageName { get; set; }
        public string? PackageId { get; set; }
        public string? Guid { get; set; }
        public string? MachineName { get; set; }
        public string? UserName { get; set; }
        public string? DataSource { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? NumRowsInserted { get; set; }
        public int? NumRowsNotInserted { get; set; }
    }
}
