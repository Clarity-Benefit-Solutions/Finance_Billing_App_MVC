using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface ILoggingdbRepository
    {
        Task<List<TBL_LOGGINGDB>> GetLoggingdbList();
        Task<List<TBLERRORLOGS>> GeterrorsList();
    }
}
