﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class EmployeeNavImportError
    {
        public string? Company { get; set; }
        public double? TotalEmployees { get; set; }
        public double? ActiveEmployees { get; set; }
        public double? EligibleEmployees { get; set; }
        public double? EnrolledEmployees { get; set; }
        public double? CobraEmployees { get; set; }
        public byte[]? SsmaTimeStamp { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public long? LoggingDbId { get; set; }
        public string? Description { get; set; }

    }
}
