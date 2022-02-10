using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStagingEdi4DebitCardSummaryError
    {
        public string AdministratorId { get; set; }
        public string AdministratorName { get; set; }
        public string NewCards { get; set; }
        public string ReplacementCards { get; set; }
        public string EmployerId { get; set; }
        public string Employer { get; set; }
        public string TotalCards { get; set; }
        public string Column1 { get; set; }
        public string Column3 { get; set; }
        public string Column5 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column10 { get; set; }
        public string Column11 { get; set; }
        public string Column13 { get; set; }
        public string Column14 { get; set; }
        public string Column16 { get; set; }
        public int? ErrorCode { get; set; }
        public int? ErrorColumn { get; set; }
    }
}
