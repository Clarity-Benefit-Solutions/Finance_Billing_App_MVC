using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface ICommonRepository
    {
        Task<bool> ExecuteSSISPackage(string guid);
    }
}
