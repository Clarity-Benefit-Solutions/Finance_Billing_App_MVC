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
    public class FileNameService: IFileNameService
    {
        private readonly IFileNameRepository _iFileNameRepository;

        public FileNameService(IFileNameRepository iFileNameRepository)
        {
            _iFileNameRepository = iFileNameRepository;
        }
        public async Task<List<TblFilesNameToUpload>> GetFileNamesList()
        {
            return await _iFileNameRepository.GetFileNamesList();
        }
    }
}
