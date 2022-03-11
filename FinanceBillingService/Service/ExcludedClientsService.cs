
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class ExcludedClientsService : IExcludedClientsService
    {
        private readonly IExcludedClientsRepository _iExcludedClientsRepository;
        private readonly IClientMasterService _iClientMasterService;
        public ExcludedClientsService(IExcludedClientsRepository iExcludedClientsRepository, IClientMasterService iClientMasterService)
        {
            _iExcludedClientsRepository = iExcludedClientsRepository;
            _iClientMasterService = iClientMasterService;
        }
        public async Task<TblExcludedClient> AddNewExcludedClient(TblExcludedClient tblExcludedClient)
        {
            return await _iExcludedClientsRepository.AddNewExcludedClient(tblExcludedClient);
        }

        public async Task<bool> AddExcludedClientFromMasterClient(string id)
        {
            bool result = false;
            TblExcludedClient tblExcludedClient = new TblExcludedClient();
            TblStagingClientsMaster tblStagingClientsMaster = await _iClientMasterService.GetMasterClientById(id);
            if (tblStagingClientsMaster != null)
            {
                tblExcludedClient.ClientName = tblStagingClientsMaster.ClientName;
                tblExcludedClient.CreateDate = DateTime.Now;
                tblExcludedClient.Bencode = tblStagingClientsMaster.ClientAlternate;
                tblExcludedClient.ClientID = (int)Convert.ToInt64(tblStagingClientsMaster.ClientId);
            }

            if (tblExcludedClient != null)
            {
                await AddNewExcludedClient(tblExcludedClient);
                result = true;
            }
            return result;
        }
        public async Task<bool> DeleteExculdedClient(int id)
        {
            return await _iExcludedClientsRepository.DeleteExculdedClient(id);
        }
    }
}
