using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class ClientRepository : IClientRepository
    {
        private Finance_BillingContext _db;
        public ClientRepository(Finance_BillingContext db)
        {
            _db = db;
        }

        public async Task<List<VwNewClient>> GetNewClientList()
        {
            return await Task.Run(() =>
            {
                return _db.VwNewClient.ToList();
            });
        }
        public async Task<List<VwExistingClient>> GetExistingClientList()
        {
            return await Task.Run(() =>
            {
                return _db.VwExistingClient.ToList();
            });
        }

        public async Task<List<VwTerminatedClient>> GetTerminatedClientList()
        {
            return await Task.Run(() =>
            {
                return _db.VwTerminatedClient.ToList();
            });
        }
        public async Task<List<SpClientDropDownData>> GetClientDropDownData()
        {
            return await Task.Run(() =>
            {
                return _db.SpClientDropDownData.FromSqlRaw("SPS_GET_CLIENTDROPDOWNDATA").ToList<SpClientDropDownData>();
            });
        }
        public async Task<List<SpExcludeClientData>> GetExcludeClientDataList()
        {
            return await Task.Run(() =>
            {
                return _db.SpExcludeClientData.FromSqlRaw("SPS_GET_EXCLUDECLIENTDATA").ToList<SpExcludeClientData>();
            });
        }
        public async Task<TblStagingClientsMaster> GetTblStagingClientById(string  clientId)
        {
            return await Task.Run(() =>
            {
                return _db.TblStagingClientsMasters.Where(x => x.ClientId == clientId && x.DivisionName != "0").FirstOrDefault();
            });
        }
        public async Task<TblExcludedClient> AddTblExcludeClient(TblExcludedClient tblExcludedClients)
        {
            return await Task.Run<TblExcludedClient>(() =>
            {
                _db.TblExcludedClients.AddAsync(tblExcludedClients);
                _db.SaveChanges();
                return tblExcludedClients;
            });
        }
        public async Task<TblExcludedClient> DeleteExculdedClient(int id)
        {
            return await Task.Run<TblExcludedClient>(() =>
            {
                TblExcludedClient tblExcludedClient = new TblExcludedClient();

                tblExcludedClient = _db.TblExcludedClients.Where(m => m.Id == id).FirstOrDefault();
                tblExcludedClient.isDeleted = true;
                _db.TblExcludedClients.Update(tblExcludedClient);
                _db.SaveChanges();
                return tblExcludedClient;
            });
        }
    }

}
