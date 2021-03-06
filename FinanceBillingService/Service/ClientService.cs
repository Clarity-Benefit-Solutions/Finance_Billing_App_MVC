using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class ClientService:IClientService
    {
        private readonly  IClientRepository _iClientRepository;
        public ClientService(IClientRepository iClientRepository) {
            _iClientRepository = iClientRepository;
        }
        public async Task<List<VwNewClient>> GetNewClientList(int take,int skip)
        {
            return await _iClientRepository.GetNewClientList(take,skip);
        }
        public async Task<List<VwExistingClient>> GetExistingClientList(int take, int skip)
        {
            return await _iClientRepository.GetExistingClientList(take,skip);
        }
        public async Task<List<VwTerminatedClient>> GetTerminatedClientList(int take, int skip)
        {
            return await _iClientRepository.GetTerminatedClientList(take,skip);
        }
        
        public async Task<List<SpClientDropDownData>> GetClientDropDownData()
        {
            return await _iClientRepository.GetClientDropDownData();
        }
        public async Task<List<SpExcludeClientData>> GetExcludeClientDataList()
        {
            return await _iClientRepository.GetExcludeClientDataList();
        }
        public async Task<TblStagingClientsMaster> GetTblStagingClientById(string clientId)
        {
            return await _iClientRepository.GetTblStagingClientById(clientId);
        }
        public async Task<TblExcludedClient> AddTblExcludeClient(TblExcludedClient tblExcludedClient)
        {
            return await _iClientRepository.AddTblExcludeClient(tblExcludedClient);
        }
        public async Task<TblExcludedClient> DeleteExculdedClient(int id)
        {
            return await _iClientRepository.DeleteExculdedClient(id);
        }
    }
}
