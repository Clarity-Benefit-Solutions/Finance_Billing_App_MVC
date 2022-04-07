using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingModel.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBillingData.Repository
{
    public class TblLoggingRepository : ITblLoggingRepository
    {
        private readonly IConfiguration _config;
        private Finance_BillingContext _db;
        public TblLoggingRepository(Finance_BillingContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }
        public async Task<TblLogging> GetTblLoggingByGUID(string guid)
        {
            TblLogging tblLogging = new TblLogging();
            tblLogging = await Task.Run<TblLogging>(() => {
                TblLogging tblLogging = new TblLogging();
                return tblLogging = _db.TblLoggings.AsQueryable().Where(c => c.Guid == guid ).FirstOrDefault();
            });
            return tblLogging;
        }

        public async Task<UploadFileErrorModel> GetAllLoggingByGuid(string guid, int? logId)
        {
            UploadFileErrorModel uploadFileErrorModel = new UploadFileErrorModel();
            try {
                string SqlconString = _config.GetConnectionString("SqlConnectionString");
                List<TblLogging> tblLoggingList = new List<TblLogging>();
                using (SqlConnection conn = new SqlConnection(SqlconString)) {
                    conn.Open();
                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("PSP_GETERRORDETAILBYGUIDANDPACKAGE", conn);
                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    // 3. add parameter to command, which will be passed to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@GUID", guid));
                    cmd.Parameters.Add(new SqlParameter("@ID", logId));
                    List<PlanDocReportError> planDoRepErrorList = new List<PlanDocReportError>();
                    // execute the command
                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        // iterate through results, printing each to console
                        var dataTable1 = new DataTable();
                        dataTable1.Load(rdr);
                        //Retrive First File Error
                        if (dataTable1.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable1);
                            // Here you get the object
                            uploadFileErrorModel.PlanDocReportErrorsList = (List<PlanDocReportError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<PlanDocReportError>));
                        }
                        //Retrive 2nd File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable2 = new DataTable();
                        dataTable2.Load(rdr);
                        if (dataTable2.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable2);
                            // Here you get the object
                            uploadFileErrorModel.PlanDocReportPriorErrorsList = (List<PlanDocReportPriorError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<PlanDocReportPriorError>));
                        }

                        //Retrive 3rd File Error
                        ////rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable3 = new DataTable();
                        dataTable3.Load(rdr);
                        if (dataTable3.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable3);
                            // Here you get the object
                            uploadFileErrorModel.DebitCardSummeryErrorsList = (List<DebitCardSummeryError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<DebitCardSummeryError>));
                        }

                        //Retrive 4th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable4 = new DataTable();
                        dataTable4.Load(rdr);
                        if (dataTable4.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable4);
                            // Here you get the object
                            uploadFileErrorModel.StaggingNpmErrorsList = (List<StaggingNpmError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<StaggingNpmError>));

                        }

                        //Retrive 5th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable5 = new DataTable();
                        dataTable5.Load(rdr);
                        if (dataTable5.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable5);
                            // Here you get the object
                            uploadFileErrorModel.StaggingQbDetailErrorsList = (List<StaggingQbDetailError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<StaggingQbDetailError>));

                        }

                        //Retrive 6th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable6 = new DataTable();
                        dataTable6.Load(rdr);
                        if (dataTable6.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable6);
                            // Here you get the object
                            uploadFileErrorModel.BrokerClientListErrorsList = (List<BrokerClientListError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<BrokerClientListError>));

                        }

                        //Retrive 7th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable7 = new DataTable();
                        dataTable7.Load(rdr);
                        if (dataTable7.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable7);
                            // Here you get the object
                            uploadFileErrorModel.ClientListErrorsList = (List<ClientListError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<ClientListError>));

                        }

                        //Retrive 8th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable8 = new DataTable();
                        dataTable8.Load(rdr);
                        if (dataTable8.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable8);
                            // Here you get the object
                            uploadFileErrorModel.CobraLettersErrorsList = (List<CobraLettersError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<CobraLettersError>));

                        }

                        //Retrive 9th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable9 = new DataTable();
                        dataTable9.Load(rdr);
                        if (dataTable9.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable9);
                            // Here you get the object
                            uploadFileErrorModel.SwiftBillingNumImportErrorsList = (List<SwiftBillingNumImportError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<SwiftBillingNumImportError>));

                        }

                        //Retrive 10th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable10 = new DataTable();
                        dataTable10.Load(rdr);
                        if (dataTable10.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable10);
                            // Here you get the object
                            uploadFileErrorModel.EmployeeNavImportErrorsList = (List<EmployeeNavImportError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<EmployeeNavImportError>));

                        }

                        //Retrive 11th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable11 = new DataTable();
                        dataTable11.Load(rdr);
                        if (dataTable11.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable11);
                            // Here you get the object
                            uploadFileErrorModel.EcExtractErrorsList = (List<EcExtractError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<EcExtractError>));

                        }

                        //Retrive 12th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable12 = new DataTable();
                        dataTable12.Load(rdr);
                        if (dataTable12.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable12);
                            // Here you get the object
                            uploadFileErrorModel.EbExtractErrorsList = (List<EbExtractError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<EbExtractError>));

                        }

                        //Retrive 13th File Error
                        //rdr.NextResult();
                        // iterate through results, printing each to console
                        var dataTable13 = new DataTable();
                        dataTable13.Load(rdr);
                        if (dataTable13.Rows.Count > 0) {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable13);
                            // Here you get the object
                            uploadFileErrorModel.SpabyacareportErrorsList = (List<SpabyacareportError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<SpabyacareportError>));

                        }
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }
            return uploadFileErrorModel;
        }

        public async Task<TblLogging> GetStatusById(string guid)
        {
            string SqlconString = _config.GetConnectionString("SqlConnectionString");
            List<TblLogging> tblLoggingList = new List<TblLogging>();
            using (SqlConnection conn = new SqlConnection(SqlconString)) {
                conn.Open();
                // 1. create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("SPS_GET_TBL_LOGGING_GUID", conn);
                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@GUID", guid));
                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader()) {
                    // iterate through results, printing each to console
                    while (rdr.Read()) {
                        TblLogging tblLogging = new TblLogging();
                        tblLogging.Id = Convert.ToInt32(rdr["Id"]);
                        tblLogging.PackageName = Convert.ToString(rdr["PackageName"]);
                        tblLogging.PackageId = Convert.ToString(rdr["PackageId"]);
                        tblLogging.Guid = Convert.ToString(rdr["Guid"]);
                        tblLogging.MachineName = Convert.ToString(rdr["MachineName"]);
                        tblLogging.UserName = Convert.ToString(rdr["UserName"]);
                        tblLogging.DataSource = Convert.ToString(rdr["DataSource"]);
                        if (!DBNull.Value.Equals(rdr["StartDateTime"])) {
                            tblLogging.StartDateTime = Convert.ToDateTime(rdr["StartDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["EndDateTime"])) {
                            tblLogging.EndDateTime = Convert.ToDateTime(rdr["EndDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsInserted"])) {
                            tblLogging.NumRowsInserted = Convert.ToInt32(rdr["NumRowsInserted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsUpdated"])) {
                            tblLogging.NumRowsUpdated = Convert.ToInt32(rdr["NumRowsUpdated"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsDeleted"])) {
                            tblLogging.NumRowsDeleted = Convert.ToInt32(rdr["NumRowsDeleted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsTotal"])) {
                            tblLogging.NumRowsTotal = Convert.ToInt32(rdr["NumRowsTotal"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsSuccess"])) {
                            tblLogging.IsSuccess = Convert.ToBoolean(rdr["IsSuccess"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsFailed"])) {
                            tblLogging.IsFailed = Convert.ToBoolean(rdr["IsFailed"]);
                        }
                        if (!DBNull.Value.Equals(rdr["IsCompleted"])) {
                            tblLogging.IsCompleted = Convert.ToBoolean(rdr["IsCompleted"]);
                        }
                        tblLoggingList.Add(tblLogging);
                    }
                }
            }
            return tblLoggingList.FirstOrDefault();
        }

        public async Task<List<ErrorFileNameList>> GetLogsForAccordion(string guid)
        {
            string SqlconString = _config.GetConnectionString("SqlConnectionString");
            List<ErrorFileNameList> errorFileNameLists = new List<ErrorFileNameList>();
            using (SqlConnection conn = new SqlConnection(SqlconString)) {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("PSP_GETLOGBYGUID", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@GUID", guid));


                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader()) {
                    // iterate through results, printing each to console
                    while (rdr.Read()) {
                        ErrorFileNameList errorFileNameList = new ErrorFileNameList();
                        errorFileNameList.ID = Convert.ToInt32(rdr["Id"]);
                        errorFileNameList.PackageName = Convert.ToString(rdr["PackageName"]);
                        errorFileNameList.PackageId = Convert.ToString(rdr["PackageId"]);
                        errorFileNameList.GUID = Convert.ToString(rdr["Guid"]);
                        errorFileNameList.MachineName = Convert.ToString(rdr["MachineName"]);
                        errorFileNameList.UserName = Convert.ToString(rdr["UserName"]);
                        errorFileNameList.DataSource = Convert.ToString(rdr["DataSource"]);
                        if (!DBNull.Value.Equals(rdr["StartDateTime"])) {
                            errorFileNameList.StartDateTime = Convert.ToDateTime(rdr["StartDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["EndDateTime"])) {
                            errorFileNameList.EndDateTime = Convert.ToDateTime(rdr["EndDateTime"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsInserted"])) {
                            errorFileNameList.NumRowsInserted = Convert.ToInt32(rdr["NumRowsInserted"]);
                        }
                        //if (!DBNull.Value.Equals(rdr["NumRowsUpdated"])) {
                        //    tblLogging.NumRowsUpdated = Convert.ToInt32(rdr["NumRowsUpdated"]);
                        //}
                        if (!DBNull.Value.Equals(rdr["NumRowsNotInserted"])) {
                            errorFileNameList.NumRowsNotInserted = Convert.ToInt32(rdr["NumRowsNotInserted"]);
                        }
                        if (!DBNull.Value.Equals(rdr["NumRowsTotal"])) {
                            errorFileNameList.NumRowsTotal = Convert.ToInt32(rdr["NumRowsTotal"]);
                        }
                        //if (!DBNull.Value.Equals(rdr["IsSuccess"])) {
                        //    tblLogging.IsSuccess = Convert.ToBoolean(rdr["IsSuccess"]);
                        //}
                        //if (!DBNull.Value.Equals(rdr["IsFailed"])) {
                        //    tblLogging.IsFailed = Convert.ToBoolean(rdr["IsFailed"]);
                        //}
                        //if (!DBNull.Value.Equals(rdr["IsCompleted"])) {
                        //    tblLogging.IsCompleted = Convert.ToBoolean(rdr["IsCompleted"]);
                        //}
                        errorFileNameLists.Add(errorFileNameList);
                    }
                }
            }
            return errorFileNameLists;
        }
    }
}
