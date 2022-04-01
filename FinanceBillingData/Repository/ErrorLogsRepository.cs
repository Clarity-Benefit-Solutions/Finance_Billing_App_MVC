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
    public class ErrorLogsRepository : IErrorLogsRepository
    {
        private Finance_BillingContext _db;
        private readonly IConfiguration _config;
        public ErrorLogsRepository(Finance_BillingContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }
        public async Task<List<TblErrorLog>> GetErrorLogs()
        {
            return await Task.Run(() =>
            {
                return _db.TblErrorLogs.ToList();
            });
        }
        public async Task<List<TBLERRORLOGS>> GetErrorLogsByLogId(long logId)
        {
            return await Task.Run(() =>
            {
                return _db.TBLERRORLOGSs.AsQueryable().Where(x => x.LoggingDbID == logId).ToList();
            });
        }
       
        
        public async Task<TblLogging> GetLoggingAndErrorByGuid(string guid,int? logId)
        {
            string SqlconString = _config.GetConnectionString("SqlConnectionString");
            List<TblLogging> tblLoggingList = new List<TblLogging>();
            using (SqlConnection conn = new SqlConnection(SqlconString))
            {
                conn.Open(); // 1. create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("[dbo].[PSP_GETERRORDETAILBYGUIDANDPACKAGE]", conn); // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure; // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@GUID", guid));
                cmd.Parameters.Add(new SqlParameter("@ID", logId));

                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        TblLogging tblLogging = new TblLogging();
                        tblLogging.Id = Convert.ToInt32(rdr["Id"]);
                        tblLogging.PackageName = Convert.ToString(rdr["PackageName"]);
                        tblLogging.PackageId = Convert.ToString(rdr["PackageId"]);
                        tblLogging.Guid = Convert.ToString(rdr["Guid"]);
                        tblLogging.MachineName = Convert.ToString(rdr["MachineName"]);
                        tblLogging.UserName = Convert.ToString(rdr["UserName"]);
                        tblLogging.DataSource = Convert.ToString(rdr["DataSource"]);
                        if (!DBNull.Value.Equals(rdr["StartDateTime"]))
                        {
                            tblLogging.StartDateTime = Convert.ToDateTime(rdr["StartDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["EndDateTime"]))
                        {
                            tblLogging.EndDateTime = Convert.ToDateTime(rdr["EndDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsInserted"]))
                        {
                            tblLogging.NumRowsInserted = Convert.ToInt32(rdr["NumRowsInserted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsUpdated"]))
                        {
                            tblLogging.NumRowsUpdated = Convert.ToInt32(rdr["NumRowsUpdated"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsDeleted"]))
                        {
                            tblLogging.NumRowsDeleted = Convert.ToInt32(rdr["NumRowsDeleted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsTotal"]))
                        {
                            tblLogging.NumRowsTotal = Convert.ToInt32(rdr["NumRowsTotal"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsSuccess"]))
                        {
                            tblLogging.IsSuccess = Convert.ToBoolean(rdr["IsSuccess"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsFailed"]))
                        {
                            tblLogging.IsFailed = Convert.ToBoolean(rdr["IsFailed"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsCompleted"]))
                        {
                            tblLogging.IsCompleted = Convert.ToBoolean(rdr["IsCompleted"]);
                        }
                        tblLoggingList.Add(tblLogging);
                    } //Read Next resultset
                    rdr.NextResult(); // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        TblLogging tblLogging = new TblLogging();
                        tblLogging.Id = Convert.ToInt32(rdr["Id"]);
                        tblLogging.PackageName = Convert.ToString(rdr["PackageName"]);
                        tblLogging.PackageId = Convert.ToString(rdr["PackageId"]);
                        tblLogging.Guid = Convert.ToString(rdr["Guid"]);
                        tblLogging.MachineName = Convert.ToString(rdr["MachineName"]);
                        tblLogging.UserName = Convert.ToString(rdr["UserName"]);
                        tblLogging.DataSource = Convert.ToString(rdr["DataSource"]);
                        if (!DBNull.Value.Equals(rdr["StartDateTime"]))
                        {
                            tblLogging.StartDateTime = Convert.ToDateTime(rdr["StartDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["EndDateTime"]))
                        {
                            tblLogging.EndDateTime = Convert.ToDateTime(rdr["EndDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsInserted"]))
                        {
                            tblLogging.NumRowsInserted = Convert.ToInt32(rdr["NumRowsInserted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsUpdated"]))
                        {
                            tblLogging.NumRowsUpdated = Convert.ToInt32(rdr["NumRowsUpdated"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsDeleted"]))
                        {
                            tblLogging.NumRowsDeleted = Convert.ToInt32(rdr["NumRowsDeleted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsTotal"]))
                        {
                            tblLogging.NumRowsTotal = Convert.ToInt32(rdr["NumRowsTotal"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsSuccess"]))
                        {
                            tblLogging.IsSuccess = Convert.ToBoolean(rdr["IsSuccess"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsFailed"]))
                        {
                            tblLogging.IsFailed = Convert.ToBoolean(rdr["IsFailed"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsCompleted"]))
                        {
                            tblLogging.IsCompleted = Convert.ToBoolean(rdr["IsCompleted"]);
                        }
                        tblLoggingList.Add(tblLogging);
                    }
                }
            }
            return tblLoggingList.FirstOrDefault();
        }


    }
}
