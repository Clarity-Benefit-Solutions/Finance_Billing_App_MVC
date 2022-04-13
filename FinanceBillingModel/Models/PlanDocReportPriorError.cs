using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
   public class PlanDocReportPriorError
    {
        //public string? LineType { get; set; }
        //public string? TpaCode { get; set; }
        //public string? Bencode { get; set; }
        //public string? EmployerName { get; set; }
        //public string? AccountTypeCode { get; set; }
        //public string? PlanId { get; set; }
        //public string? PyStartDate { get; set; }
        //public string? PlanEndDate { get; set; }
        //public string? GraceRoll { get; set; }
        //public string? RunoutDate { get; set; }
        //public string? TermRunoutDate { get; set; }
        //public string? PlanMin { get; set; }
        //public string? PlanMax { get; set; }
        //public DateTime? RunoutDateDt { get; set; }
        //public string? BillableRunout { get; set; }
        //public string? AccountUniqueKey { get; set; }
        //public string? TermRunoutDateNumber { get; set; }
        //public DateTime? PlanEndDateDt { get; set; }
        //public int? RunoutDateNumber { get; set; }
        //public int? ErrorCode { get; set; }
        //public string? ErrorColumn { get; set; }
        //public long? ErrorRowNo { get; set; }
        //public long? LoggingDbId { get; set; }
        //public string? Description { get; set; }
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }

    }
}
