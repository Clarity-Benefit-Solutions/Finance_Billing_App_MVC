using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IClientRepository
    {
        Task<List<VwNewClient>> GetNewClientList();
        Task<List<VwExistingClient>> GetExistingClientList();
        Task<List<VwTerminatedClient>> GetTerminatedClientList();
        Task<List<SpClientDropDownData>> GetClientDropDownData();
        Task<List<SpExcludeClientData>> GetExcludeClientDataList();
    }
}
