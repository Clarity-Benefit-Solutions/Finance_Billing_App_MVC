using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Models
{
    public class Analytics
    {
        public List<ClientToProductViewModel> clientToProductViewModels { get; set; }
        public List<ClientToClientViewModel> clientToClientViewModels{ get; set; }

    }
}
