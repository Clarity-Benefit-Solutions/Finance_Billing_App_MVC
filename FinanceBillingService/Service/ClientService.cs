using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class ClientService:IClientService
    {
        private IClientRepository _iClientRepository;
        public ClientService(IClientRepository iClientRepository) {
            _iClientRepository = iClientRepository;
        }
        public async Task<List<VwNewClient>> GetNewClientList()
        {
            return await _iClientRepository.GetNewClientList();
        }
        public async Task<List<VwExistingClient>> GetExistingClientList()
        {
            return await _iClientRepository.GetExistingClientList();
        }
        public async Task<List<VwTerminatedClient>> GetTerminatedClientList()
        {
            return await _iClientRepository.GetTerminatedClientList();
        }
        
        public async Task<List<SpClientDropDownData>> GetClientDropDownData()
        {
            return await _iClientRepository.GetClientDropDownData();
        }
        public async Task<List<SpExcludeClientData>> GetExcludeClientDataList()
        {
            return await _iClientRepository.GetExcludeClientDataList();
        }
    }
}
