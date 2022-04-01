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
    public class TblLoggingService: ITblLoggingService
    {
        private readonly ITblLoggingRepository _tblLoggingRepository;
        public TblLoggingService(ITblLoggingRepository tblLoggingRepository)
        {
            _tblLoggingRepository = tblLoggingRepository;
        }

        public async Task<TblLogging> GetLoggingByGuid(string guid)
        {
            return await _tblLoggingRepository.GetTblLoggingByGUID(guid);

        }

        public async Task<TblLogging> GetTblLoggingByGUID(string guid)
        {
            return await  _tblLoggingRepository.GetTblLoggingByGUID(guid);
        }

        public async Task<TblLogging> GetAllLoggingByGuid(string guid, int? logId)
        {
            return await _tblLoggingRepository.GetAllLoggingByGuid(guid, logId);
        }
    }
}
