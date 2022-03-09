using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IFileNameRepository
    {
        Task<List<TblFilesNameToUpload>> GetFileNamesList();
    }
}
