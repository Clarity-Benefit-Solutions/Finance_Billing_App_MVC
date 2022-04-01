using FinanceBillingData.Entities;
using FinanceBillingModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface ITblLoggingRepository
    {
        Task<TblLogging> GetTblLoggingByGUID(string guid);
        Task<UploadFileErrorModel> GetAllLoggingByGuid(string guid, int? logId);
    }
}
