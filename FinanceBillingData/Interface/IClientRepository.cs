using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IClientRepository
    {
        Task<List<VwNewClient>> GetNewClientList(int take, int skip);
        Task<List<VwExistingClient>> GetExistingClientList(int take, int skip);
        Task<List<VwTerminatedClient>> GetTerminatedClientList(int take, int skip);
        Task<List<SpClientDropDownData>> GetClientDropDownData();
        Task<List<SpExcludeClientData>> GetExcludeClientDataList(); 
        Task<TblStagingClientsMaster> GetTblStagingClientById(string clientId);
        Task<TblExcludedClient> AddTblExcludeClient(TblExcludedClient tblExcludedClients);
        Task<TblExcludedClient> DeleteExculdedClient(int id); 

    }
}
