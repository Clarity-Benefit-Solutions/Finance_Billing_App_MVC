using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Entities
{
    public partial class TblQBClients
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string BenCode { get; set; }
        public string ServiceID { get; set; }
        public string Status { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
