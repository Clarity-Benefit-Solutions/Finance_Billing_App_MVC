using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class TblStagingEmployeeNavImport
    {
        public string Company { get; set; }
        public double? TotalEmployees { get; set; }
        public double? ActiveEmployees { get; set; }
        public double? EligibleEmployees { get; set; }
        public double? EnrolledEmployees { get; set; }
        public double? CobraEmployees { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
