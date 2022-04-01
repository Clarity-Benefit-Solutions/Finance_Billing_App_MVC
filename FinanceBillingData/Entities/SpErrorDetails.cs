using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class SpErrorDetails
    {
        public string? LineType { get; set; }
        public string? TPACode { get; set; }
        public string? BenCode { get; set; }
        public string? EmployerName { get; set; }
        public string? AccountTypeCode { get; set; }
        public string? PlanId { get; set; }
        public string? PyStartDate { get; set; }
        public string? PlainEndDate { get; set; }
        public string? GraceRoll { get; set; }
        public string? RunoutDate { get; set; }
        public string? TermRunoutDate { get; set; }
        public string? PlainMin { get; set; }
        public string? PlainMax { get; set; }
        public string? RunoutDateDt { get; set; }
        public string? BillableRunOut { get; set; }
        public string? AccountUniqueKey { get; set; }
        public string? TermRunoutDateNumber { get; set; }
        public string? PlanEndDateDt { get; set; }
        public int? RunoutDateNumber { get; set; }
        public int? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public long? ErrorRowNo { get; set; }
        public long? LoggingDbId { get; set; }
        
    }
}
