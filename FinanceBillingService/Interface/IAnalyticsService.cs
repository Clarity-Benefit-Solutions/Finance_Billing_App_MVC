using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface  IAnalyticsService
    {
        Task<List<ClientProductComparison>> GetListClientProductComparison(int take, int skip);
        Task<List<ClientToClientComparison>> GetListClientToClientComparison(int take, int skip);

    }
}
