using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class ApplicationSettingRepository : IApplicationSettingRepository
    {
        private Finance_BillingContext _db;
        private readonly IConfiguration _config;
        public ApplicationSettingRepository(Finance_BillingContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }
        public async Task<ApplicationSetting> GetApplicationSettingByName(string settingName)
        {
            return await Task.Run<ApplicationSetting>(() =>
            {
                return _db.ApplicationSetting.Where(x => x.SettingName == settingName).FirstOrDefault();
            });
        }
        public async Task<bool> UpdateApplicationSettingValueByName(string settingName, string settingValue)
        {
            return await Task.Run<bool>(() =>
            {
                ApplicationSetting applicationSetting = _db.ApplicationSetting.Where(x => x.SettingName == settingName).FirstOrDefault();
                if (applicationSetting != null)
                {
                    applicationSetting.SettingValue = settingValue;
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                };
            });
        }

        public async Task<bool> GetSSPApplicationSettingByName(string settingName)
        {
            bool result = false;
            string SqlconString = _config.GetConnectionString("SqlConnectionString");
            List<TblLogging> tblLoggingList = new List<TblLogging>();
            using (SqlConnection conn = new SqlConnection(SqlconString))
            {
                conn.Open(); // 1. create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("[dbo].[PSP_GET_APPLICATIONSETTING_VALUE]", conn); // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure; // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SettingName", settingName));

                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        TblLogging tblLogging = new TblLogging();
                        result=Convert.ToBoolean(rdr["Result"]);
                    }
                }
            }
            return result;
        }
    }
}
