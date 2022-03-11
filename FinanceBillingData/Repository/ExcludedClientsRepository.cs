﻿
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
        public async Task<bool> DeleteExculdedClient(int id)
        {
            return await Task.Run<bool>(() =>
            {
                bool isSucess = true;
                TblExcludedClient tblExcludedClient = new TblExcludedClient();
                tblExcludedClient = _db.TblExcludedClients.Where(m => m.Id == id).FirstOrDefault();
                tblExcludedClient.isDeleted = true;
                _db.TblExcludedClients.Update(tblExcludedClient);
                _db.SaveChanges();
                return isSucess;
            });
        }
    }
}