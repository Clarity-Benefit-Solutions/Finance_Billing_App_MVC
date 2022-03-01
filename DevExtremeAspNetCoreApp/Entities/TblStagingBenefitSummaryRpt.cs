using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingBenefitSummaryRpt
    {
        public string TpaId { get; set; }
        public string EmprId { get; set; }
        public string EmprName { get; set; }
        public string PlanId { get; set; }
        public string Label { get; set; }
        public string Label2 { get; set; }
        public int? Cnt { get; set; }
    }
}
