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
    public class ApplicationSettingService: IApplicationSettingService
    {
        public readonly IApplicationSettingRepository _iApplicationSettingRepository;
        public ApplicationSettingService(IApplicationSettingRepository iApplicationSettingRepository)
        {
            _iApplicationSettingRepository = iApplicationSettingRepository;
        }
        public async Task<ApplicationSetting> GetApplicationSettingByName(string settingName)
        {

            return await _iApplicationSettingRepository.GetApplicationSettingByName(settingName);
        }
        public async Task<bool> UpdateApplicationSettingValueByName(string settingName, string settingValue)
        {

            return await _iApplicationSettingRepository.UpdateApplicationSettingValueByName(settingName, settingValue);
        }
        public async Task<bool> GetSSPApplicationSettingByName(string settingName)
        {

            return await _iApplicationSettingRepository.GetSSPApplicationSettingByName(settingName);
        }
    }
}
