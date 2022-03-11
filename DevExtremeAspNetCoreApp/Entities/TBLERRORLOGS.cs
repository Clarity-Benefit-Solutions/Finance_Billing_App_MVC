using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinaceBilling.Entities
{
    public class TBLERRORLOGS
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string PackageName { get; set; }
        public string TaskName { get; set; }
        public int ErrorCode { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string ErrorDescription { get; set; }

        public DateTime Dated { get; set; }

        [Column(TypeName = "bigint")]
        public int LoggingDbID { get; set; }
    }
}


      
