using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceBillingData.Repository
{
    public class ErrorLogsRepository : IErrorLogsRepository
    {
        private Finance_BillingContext _db;
        public ErrorLogsRepository(Finance_BillingContext db)
        {
            _db = db;
        }
    }
}
