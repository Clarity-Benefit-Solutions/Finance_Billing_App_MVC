using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingCobraLetter
    {
        public string ClientName { get; set; }
        public string DivisionName { get; set; }
        public string ModeOrder { get; set; }
        public string ModeName { get; set; }
        public string Description { get; set; }
        public int? Qty { get; set; }
    }
}
