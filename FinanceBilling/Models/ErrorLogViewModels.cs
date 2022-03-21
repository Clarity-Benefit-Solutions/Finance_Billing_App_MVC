using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBilling.Models
{
    public partial class ErrorLogViewModels
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string PackageName { get; set; }
        public string TaskName { get; set; }
        public int ErrorCode { get; set; }

        public string ErrorDescription { get; set; }
        public DateTime Dated { get; set; }

        public int LoggingDbID { get; set; }
    }
}
