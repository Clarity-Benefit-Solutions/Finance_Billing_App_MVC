using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class AnalyticsService: IAnalyticsService
    {
        public readonly IAnalyticsRepository _analyticsRepository;
        public AnalyticsService(IAnalyticsRepository analyticsRepository)
        {
            _analyticsRepository = analyticsRepository;
        }
        public async Task<List<ClientProductComparison>> GetListClientProductComparison(int take,int skip)
        {
            return await _analyticsRepository.GetListClientProductComparison(take,skip);
        }
        public async Task<List<ClientToClientComparison>> GetListClientToClientComparison(int take, int skip)
        {
            return await _analyticsRepository.GetListClientToClientComparison(take,skip);
        }
    }
}
