using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace FinanceBillingData.Entities
{
   public partial class TBLERRORLOGS
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


      
      
      
      
      