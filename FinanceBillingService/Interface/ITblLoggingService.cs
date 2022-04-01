﻿using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingService.Interface
{
    public interface ITblLoggingService
    {
        Task<TblLogging> GetTblLoggingByGUID(string guid);
        Task<TblLogging> GetLoggingByGuid(string guid);
        Task<List<LogsByGuid>> GetLoggByGuid(string guid);


    }
}
