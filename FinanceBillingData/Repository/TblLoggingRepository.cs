using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingModel.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            tblLogging = await Task.Run<TblLogging>(() =>
            {
                TblLogging tblLogging = new TblLogging();
                return tblLogging = _db.TblLoggings.AsQueryable().Where(c => c.Guid == guid).FirstOrDefault();
            });
            return tblLogging;
        }

        public async Task<TblLogging> GetAllLoggingByGuid(string guid, int? logId)
        {
            try
            {
                string SqlconString = _config.GetConnectionString("SqlConnectionString");
                List<TblLogging> tblLoggingList = new List<TblLogging>();
                using (SqlConnection conn = new SqlConnection(SqlconString))
                {
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



                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        var dataTable = new DataTable();
                        dataTable.Load(rdr);
                        //Retrive First File Error
                        List<PlanDocReportError> planDocReportErrorList = new List<PlanDocReportError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            planDocReportErrorList = (List<PlanDocReportError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<PlanDocReportError>));
                        }
                        //Retrive 2nd File Error
                        List<PlanDocReportPriorError> planDocReportPriorErrorList = new List<PlanDocReportPriorError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            planDocReportPriorErrorList = (List<PlanDocReportPriorError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<PlanDocReportPriorError>));
                        }
                        //Retrive 3rd File Error
                        List<DebitCardSummeryError> debitCardSummeryErrorList = new List<DebitCardSummeryError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            debitCardSummeryErrorList = (List<DebitCardSummeryError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<DebitCardSummeryError>));
                        }
                        //Retrive 4th File Error
                        List<StaggingNpmError> staggingNpmErrorList = new List<StaggingNpmError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            staggingNpmErrorList = (List<StaggingNpmError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<StaggingNpmError>));
                        }
                        //Retrive 5th File Error
                        List<StaggingQbDetailError> staggingQbDetailErrorList = new List<StaggingQbDetailError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            staggingQbDetailErrorList = (List<StaggingQbDetailError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<StaggingQbDetailError>));

                        }
                        //Retrive 6th File Error
                        List<BrokerClientListError> brokerClientListErrorList = new List<BrokerClientListError>();
                        if (dataTable.Rows.Count > 0)
                        {
                            var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                            // Here you get the object
                            brokerClientListErrorList = (List<BrokerClientListError>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<BrokerClientListError>));

                        }
                    }
                }
                return tblLoggingList.FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
