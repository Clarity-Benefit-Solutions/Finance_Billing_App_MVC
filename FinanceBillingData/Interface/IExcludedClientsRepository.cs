
using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IExcludedClientsRepository
    {
        Task<TblExcludedClient> AddNewExcludedClient(TblExcludedClient tblExcludedClient);
        Task<TblExcludedClient> DeleteExculdedClient(int id);
        Task<List<TblExcludedClient>> GetAllExcludedClient(int take, int skip);
    }
}
