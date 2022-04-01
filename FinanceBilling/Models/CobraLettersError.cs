using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class CobraLettersError
    {
        public string? ClientName { get; set; }
        public string? DivisionName { get; set; }
        public string? ModeOrder { get; set; }
        public string? ModeName { get; set; }
        public string? Description { get; set; }
        public long? Qty { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public long? LoggingDbId { get; set; }
        //public string? Description { get; set; }



    }
}
