﻿using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class QuickBookClientsRepository : IQuickBookClientsRepository
    {
        private Finance_BillingContext _db;
        public QuickBookClientsRepository(Finance_BillingContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Get Active client list
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        public async Task<List<TblQBClients>> GetAllQuickBookClientList(int take, int skip)
        {
            return await Task.Run<List<TblQBClients>>(() =>
            {
                List<TblQBClients> result = _db.TblQBClients.AsQueryable().Where(x => x.IsDeleted == false).Take(take).Skip(skip).ToList();
                return result;
            });
        }
        /// <summary>
        /// Get Client Detail by Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<TblQBClients> GetQuickBookClientById(int clientId)
        {
            return await Task.Run<TblQBClients>(() =>
            {
                TblQBClients tblQBClientsResult = _db.TblQBClients.AsQueryable().Where(x => x.ClientID == clientId
                 && x.IsDeleted == false).FirstOrDefault();
                return tblQBClientsResult;
            });
        }
        /// <summary>
        /// Add Quick book Clients
        /// </summary>
        /// <param name="tblQBClients"></param>
        /// <returns></returns>
        public async Task<TblQBClients> AddNewQuickBookClient(TblQBClients tblQBClients)
        {
            return await Task.Run<TblQBClients>(() =>
            {
                TblQBClients tblQBClientsResult = _db.TblQBClients.AsQueryable().Where(x => x.ClientID == tblQBClients.ClientID
                 && x.IsDeleted == false).FirstOrDefault();
                if (tblQBClientsResult == null)
                {
                    tblQBClients.CreatedDate = DateTime.UtcNow;
                    _db.TblQBClients.Add(tblQBClients);
                    _db.SaveChanges();
                }
                return tblQBClientsResult;
            });
        }
        /// <summary>
        /// Update quickbook clients
        /// </summary>
        /// <param name="tblQBClients"></param>
        /// <returns></returns>
        public async Task<TblQBClients> UpdateQuickBookClient(TblQBClients tblQBClients)
        {
            return await Task.Run<TblQBClients>(() =>
            {
                TblQBClients tblQBClientsResult = _db.TblQBClients.AsQueryable().Where(x => x.ClientID == tblQBClients.ClientID
                 && x.IsDeleted == false).FirstOrDefault();
                if (tblQBClientsResult!= null)
                {
                    tblQBClientsResult.FirstName = tblQBClients.FirstName;
                    tblQBClientsResult.LastName = tblQBClients.LastName;
                    tblQBClientsResult.BenCode = tblQBClients.BenCode;
                    tblQBClientsResult.Status = tblQBClients.Status;
                    tblQBClientsResult.ModifiedDate = DateTime.UtcNow;
                    _db.SaveChanges();
                }
                return tblQBClientsResult;
            });
        }
        /// <summary>
        /// Delete quickbook clients
        /// </summary>
        /// <param name="tblQBClients"></param>
        /// <returns></returns>
        public async Task<TblQBClients> DeleteQuickBookClient(int clientId)
        {
            return await Task.Run<TblQBClients>(() =>
            {
                TblQBClients tblQBClientsResult = _db.TblQBClients.AsQueryable().Where(x => x.ClientID == clientId
                 && x.IsDeleted == false).FirstOrDefault();
                if (tblQBClientsResult != null)
                {
                    tblQBClientsResult.IsDeleted = true;
                    tblQBClientsResult.ModifiedDate = DateTime.UtcNow;
                    _db.SaveChanges();
                }
                return tblQBClientsResult;
            });
        }
    }
}