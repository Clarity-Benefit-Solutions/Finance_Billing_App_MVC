using FinanceBillingData.Entities;
using FinanceBillingModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface ITblLoggingService
    {
        Task<TblLogging> GetTblLoggingByGUID(string guid); 
         Task<TblLogging> GetLoggingByGuid(string guid);
        Task<UploadFileErrorModel> GetAllLoggingByGuid(string guid, int? logId);
        Task<ListFileError> AllDataLogsForAccordion(string guid, int Id);

        Task<List<ErrorFileNameList>> GetLogsForAccordion(string guid);

    }
}
