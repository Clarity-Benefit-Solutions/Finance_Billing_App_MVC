using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Interface
{
    public interface IApplicationSettingRepository
    {
        Task<ApplicationSetting> GetApplicationSettingByName(string settingName);
        Task<bool> UpdateApplicationSettingValueByName(string settingName, string settingValue);
        Task<bool> GetSSPApplicationSettingByName(string settingName);
    }
}
