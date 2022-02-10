using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblErrorLog
    {
        public int LogId { get; set; }
        public string SqlState { get; set; }
        public string ErrNo { get; set; }
        public string ErrSource { get; set; }
        public string ErrMsg { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
