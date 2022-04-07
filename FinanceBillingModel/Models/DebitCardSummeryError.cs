using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class DebitCardSummeryError
    {
        //public string? AdminId { get; set; }
        //public string? Filler1 { get; set; }
        //public string? AdminName { get; set; }
        //public string? Filler2 { get; set; }
        //public string? EmployerId { get; set; }
        //public string? Filler3 { get; set; }
        //public string? EmployerName { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
        //public int? NewCardCount { get; set; }
        //public string? Filler6 { get; set; }
        //public string? Filler7 { get; set; }
        //public int? ReplacementCardCount { get; set; }
        //public string Filler8 { get; set; }
        //public string Filler9 { get; set; }
        //public int? TotalCardsCount { get; set; }
        //public int? LoggingDbId { get; set; }

        //public string? ErrorCode { get; set; }
        //public long? ErrorColumn { get; set; }
        //public string? Description { get; set; }
        public string PackageName { get; set; }
        public string ErrorColumn { get; set; }
        public string ErrorRowNo { get; set; }
        public string LoggingDbId { get; set; }
        public string ErrorDescription { get; set; }
        public string EntityAttributes { get; set; }
    }

}
