using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class ClientMasterRepository: IClientMasterRepository
    {
        private Finance_BillingContext _db;
        public ClientMasterRepository(Finance_BillingContext db)
        {
            _db = db;
        }
        public async Task<TblStagingClientsMaster> GetMasterClientById(string id)
        {
            return await Task.Run<TblStagingClientsMaster>(() =>
            {
                return _db.TblStagingClientsMasters.Where(x => x.ClientId == id && x.DivisionName != "0").FirstOrDefault();
            });
        }
    }
}
