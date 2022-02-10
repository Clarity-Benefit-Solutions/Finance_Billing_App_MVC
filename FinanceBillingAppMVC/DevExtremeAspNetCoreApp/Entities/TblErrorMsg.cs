using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblErrorMsg
    {
        public int LogId { get; set; }
        public string LogLevel { get; set; }
        public string LogSource { get; set; }
        public string LogMsg { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
