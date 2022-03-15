using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class AnalyticsRepository: IAnalyticsRepository
    {
        private Finance_BillingContext _db;
        public AnalyticsRepository(Finance_BillingContext db) 
        {
            _db = db;
        }
        public async Task<List<ClientProductComparison>> GetListClientProductComparison(int take, int skip)
        {
            return await Task.Run(() => {
                return _db.ClientProductComparisons.Take(take).Skip(skip).ToList(); 
            });
        }
        public async Task<List<ClientToClientComparison>> GetListClientToClientComparison(int take, int skip)
        {
            return await Task.Run(() => {
                return _db.ClientToClientComparisons.Take(take).Skip(skip).ToList();
            });
        }
    }
}
