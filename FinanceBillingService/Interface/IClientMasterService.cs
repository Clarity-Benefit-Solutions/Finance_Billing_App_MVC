using FinanceBillingData.Entities;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IClientMasterService
    {
        Task<TblStagingClientsMaster> GetMasterClientById(string id);
    }
}
