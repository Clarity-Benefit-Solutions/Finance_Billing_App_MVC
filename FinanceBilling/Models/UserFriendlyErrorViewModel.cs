using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBilling.Models
{
    public class UserFriendlyErrorViewModel
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
        public string? RunoutDateNumber { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public string? ErrorRowNo { get; set; }
        public string? LoggingDbId { get; set; }
    }
}
