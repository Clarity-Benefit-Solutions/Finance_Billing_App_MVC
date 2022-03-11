using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class ClientMasterService: IClientMasterService
    {
        private readonly IClientMasterRepository _iClientMasterRepository;
        public ClientMasterService(IClientMasterRepository iClientMasterRepository)
        {
            _iClientMasterRepository = iClientMasterRepository;
        }
        public async Task<TblStagingClientsMaster> GetMasterClientById(string id)
        {
            return await _iClientMasterRepository.GetMasterClientById(id);
        }
    }
}
