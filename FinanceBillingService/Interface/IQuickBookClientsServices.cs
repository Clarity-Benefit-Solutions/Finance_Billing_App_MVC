using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface IQuickBookClientsServices
    {
        Task<List<TblQBClients>> GetAllQuickBookClientList();
        Task<TblQBClients> GetQuickBookClientById(int clientId);
        Task<TblQBClients> AddAndUpdateQuickBookClient(TblQBClients tblQBClients);
        Task<TblQBClients> AddNewQuickBookClient(TblQBClients tblQBClients);
        Task<TblQBClients> UpdateQuickBookClient(TblQBClients tblQBClients);
        Task<TblQBClients> DeleteQuickBookClient(int clientId);
    }
}
