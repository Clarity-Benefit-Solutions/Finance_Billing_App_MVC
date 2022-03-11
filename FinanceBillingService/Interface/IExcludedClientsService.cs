using FinaceBilling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IExcludedClientsService
    {
        Task<TblExcludedClient> AddNewExcludedClient(TblExcludedClient tblExcludedClient);
        Task<bool> AddExcludedClientFromMasterClient(string id);
    }
}
