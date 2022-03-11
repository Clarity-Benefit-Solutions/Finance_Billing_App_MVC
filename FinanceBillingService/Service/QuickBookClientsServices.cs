using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Service
{
    public class QuickBookClientsServices : IQuickBookClientsServices
    {
        private IQuickBookClientsRepository _iQuickBookClientsRepository;

        public QuickBookClientsServices(IQuickBookClientsRepository iQuickBookClientsRepository)
        {
            _iQuickBookClientsRepository = iQuickBookClientsRepository;
        }
        /// <summary>
        /// Get Quickbook clients
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        public async Task<List<TblQBClients>> GetAllQuickBookClientList(int take, int skip)
        {
            return await _iQuickBookClientsRepository.GetAllQuickBookClientList(take, skip);
        }
        /// <summary>
        /// Get Quickbook Client by Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<TblQBClients> GetQuickBookClientById(int clientId)
        {
            return await _iQuickBookClientsRepository.GetQuickBookClientById(clientId);
        }
        public async Task<TblQBClients> AddAndUpdateQuickBookClient(TblQBClients tblQBClients)
        {
            TblQBClients tblQBClientsResponse = new TblQBClients();
            TblQBClients tblQBClientsResult = await _iQuickBookClientsRepository.GetQuickBookClientById(tblQBClients.ClientID);
            if (tblQBClientsResult?.ClientID > 0)
            {
                tblQBClientsResponse = await _iQuickBookClientsRepository.UpdateQuickBookClient(tblQBClients);
            }
            else
            {
                tblQBClientsResponse = await _iQuickBookClientsRepository.AddNewQuickBookClient(tblQBClients);
            }
            return tblQBClientsResponse;
        }
        /// <summary>
        /// Add New client
        /// </summary>
        /// <param name="tblQBClients"></param>
        /// <returns></returns>
        public async Task<TblQBClients> AddNewQuickBookClient(TblQBClients tblQBClients)
        {
            return await _iQuickBookClientsRepository.AddNewQuickBookClient(tblQBClients);
        }
        /// <summary>
        /// Update new Client
        /// </summary>
        /// <param name="tblQBClients"></param>
        /// <returns></returns>
        public async Task<TblQBClients> UpdateQuickBookClient(TblQBClients tblQBClients)
        {
            return await _iQuickBookClientsRepository.UpdateQuickBookClient(tblQBClients);
        }

        /// <summary>
        /// Delete quickbook client
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<TblQBClients> DeleteQuickBookClient(int clientId)
        {
            return await _iQuickBookClientsRepository.DeleteQuickBookClient(clientId);
        }
    }
}
