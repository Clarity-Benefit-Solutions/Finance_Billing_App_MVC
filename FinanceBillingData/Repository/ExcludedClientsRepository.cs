
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class ExcludedClientsRepository: IExcludedClientsRepository
    {
        private Finance_BillingContext _db;
        public ExcludedClientsRepository(Finance_BillingContext db)
        {
            _db = db;
        }

        public async Task<TblExcludedClient> AddNewExcludedClient (TblExcludedClient tblExcludedClient)
        {
            return await Task.Run<TblExcludedClient>(() =>
            {
                _db.TblExcludedClients.Add(tblExcludedClient);
                _db.SaveChanges();
                return tblExcludedClient;
            });
        }
        public async Task<TblExcludedClient> DeleteExculdedClient(int id)
        {
            return await Task.Run<TblExcludedClient>(() =>
            {
                TblExcludedClient tblExcludedClient = _db.TblExcludedClients.AsQueryable().Where(m => m.Id == id
                 && m.isDeleted == false).FirstOrDefault();
                if (tblExcludedClient != null)
                {
                    tblExcludedClient.isDeleted = true;
                    //tblExcludedClient.ModifiedDate = DateTime.UtcNow;
                    _db.SaveChanges();
                }
                return tblExcludedClient;
            });
            //return await Task.Run<bool>(() =>
            //{
            //    bool isSucess = true;
            //    TblExcludedClient tblExcludedClient = new TblExcludedClient();
            //    tblExcludedClient = _db.TblExcludedClients.Where(m => m.Id == id).FirstOrDefault();
            //    tblExcludedClient.isDeleted = true;
            //    _db.TblExcludedClients.Update(tblExcludedClient);
            //    _db.SaveChanges();
            //    return isSucess;
            //});
        }
        public async Task <List<TblExcludedClient>> GetAllExcludedClient(int take, int skip)
        {
            return await Task.Run(() =>
            {
                return _db.TblExcludedClients.Where(m=>m.isDeleted == null).Take(take).Skip(skip).ToList();
            });
        }
    }
}
