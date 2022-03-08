using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingEdi4DebitCardSummary
    {
        public string AdminId { get; set; }
        public string Filler1 { get; set; }
        public string AdminName { get; set; }
        public string Filler2 { get; set; }
        public string EmployerId { get; set; }
        public string Filler3 { get; set; }
        public string EmployerName { get; set; }
        public string Filler4 { get; set; }
        public string Filler5 { get; set; }
        public int? NewCardCount { get; set; }
        public string Filler6 { get; set; }
        public string Filler7 { get; set; }
        public int? ReplacementCardCount { get; set; }
        public string Filler8 { get; set; }
        public string Filler9 { get; set; }
        public int? TotalCardsCount { get; set; }
    }
}
