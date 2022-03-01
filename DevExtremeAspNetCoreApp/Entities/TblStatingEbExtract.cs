using System;
using System.Collections.Generic;

#nullable disable

namespace DevExtremeAspNetCoreApp.Entities
{
    public partial class TblStatingEbExtract
    {
        public string RecordType { get; set; }
        public string TpaId { get; set; }
        public string EmployerId { get; set; }
        public string Division { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeSocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string UserDefinedField { get; set; }
        public int? EmployeeStatus { get; set; }
        public string TerminationDate { get; set; }
    }
}
