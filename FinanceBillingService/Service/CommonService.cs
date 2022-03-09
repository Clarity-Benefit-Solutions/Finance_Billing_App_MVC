using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class CommonService: ICommonService
    {
        private readonly ICommonRepository _iCommonRepository;
        public CommonService(ICommonRepository iCommonRepository)
        {
            _iCommonRepository = iCommonRepository;
        }
        public async Task<bool> ExecuteSSISPackage(string guid)
        {
            return await _iCommonRepository.ExecuteSSISPackage(guid);
        }
    }
}
