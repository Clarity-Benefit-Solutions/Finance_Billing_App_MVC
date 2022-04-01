using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public class EbExtractError
    {
        public string? RecordType { get; set; }
        public string? TpaId { get; set; }
        public string? EmployerId { get; set; }
        public string? Division { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeSocialSecurityNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? UserDefinedField { get; set; }
        public int? EmployeeStatus { get; set; }
        public string? TerminationDate { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorColumn { get; set; }
        public long? LoggingDbId { get; set; }
        public string? Description { get; set; }

    }
}
