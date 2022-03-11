using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    
        public interface IClientService
        {
            Task<List<VwNewClient>> GetNewClientList();
            Task<List<VwExistingClient>> GetExistingClientList();
            Task<List<VwTerminatedClient>> GetTerminatedClientList();
            Task<List<SpClientDropDownData>> GetClientDropDownData();
            Task<List<SpExcludeClientData>> GetExcludeClientDataList();
            Task<TblStagingClientsMaster> GetTblStagingClientById(string clientId);
            Task<TblExcludedClient> AddTblExcludeClient(TblExcludedClient tblExcludedClient);

            Task<TblExcludedClient> DeleteExculdedClient(int id);
        }
    
}
