using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface ICommonService
    {
        Task<List<TblLogging>> ExecuteSSISPackage(string guid);
    }
}
