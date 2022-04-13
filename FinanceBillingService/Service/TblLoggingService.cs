using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingModel.Models;
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

        public async Task<TblLogging> GetTblLoggingByGUID(string guid)
        {
            return await _tblLoggingRepository.GetTblLoggingByGUID(guid);
        }

        public async Task<TblLogging> GetLoggingByGuid(string guid)
        {
            return await  _tblLoggingRepository.GetTblLoggingByGUID(guid);
        }

        public async Task<UploadFileErrorModel> GetAllLoggingByGuid(string guid, int? logId)
        {
            return await _tblLoggingRepository.GetAllLoggingByGuid(guid, logId);
        }

        public async Task<List<ErrorFileNameList>> GetLogsForAccordion(string guid)
        {
            return await _tblLoggingRepository.GetLogsForAccordion(guid);

        }

        public async Task<ListFileError> AllDataLogsForAccordion(string guid, int Id)
        {
            return await _tblLoggingRepository.AllDataLogsForAccordion(guid,Id );

        }
    }
}
