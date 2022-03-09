using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class FileNameRepository: IFileNameRepository
    {

        private Finance_BillingContext _db;
        public FileNameRepository(Finance_BillingContext db)
        {
            _db = db;
        }

        public async Task<List<TblFilesNameToUpload>> GetFileNamesList()
        {
            return await Task.Run(() =>
            {
                return _db.TblFilesNameToUploads.ToList();
            });
        }
    }
}
