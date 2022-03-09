using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class CommonRepository: ICommonRepository
    {
        private readonly IConfiguration _config;
        private Finance_BillingContext _db;
        public CommonRepository(Finance_BillingContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }
        public async Task<bool> ExecuteSSISPackage(string guid) {
            bool isSuccess = false;
            return await Task.Run(() =>
            {
                SqlConnection sqlCon = null;

                String SqlconString = _config.GetConnectionString("SqlConnectionString");
                using (sqlCon = new SqlConnection(SqlconString))
                {
                    sqlCon.Open();
                    SqlCommand sql_cmnd = new SqlCommand("dbo.EXECUTE_SSIS_FINANCEBILLING", sqlCon);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@inputParameter", SqlDbType.NVarChar).Value = guid;
                    // sql_cmnd.Parameters.AddWithValue("@output_execution_id", SqlDbType.NVarChar).Value = NewGuid.ToString();
                    SqlParameter parm3 = new SqlParameter("@output_execution_id", SqlDbType.Int);
                    parm3.Direction = ParameterDirection.Output;
                    sql_cmnd.Parameters.Add(parm3);
                    var lblsmsg = sql_cmnd.ExecuteNonQuery();
                    sql_cmnd.ExecuteNonQuery();
                    sqlCon.Close();
                    isSuccess = true;

                }
                return isSuccess;
            });
        }
    }
}
