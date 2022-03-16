using DevExtremeAspNetCoreApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Net.Http.Headers;
using System.Threading.Tasks;
using DevExtremeAspNetCoreApp.Custom.Attributes;
using DevExtremeAspNetCoreApp.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAspNetCoreApp.Controllers
{
    public class UploadFIleController : Controller
    {
        private IHostingEnvironment _env { get; set; }

        private readonly IConfiguration _config;
        private Finance_BillingContext _db;

        public UploadFIleController(IHostingEnvironment env, Finance_BillingContext db, IConfiguration config)
        {
            _env = env;
            _config = config;
            _db = db;
        }


        [HttpGet]
        public IActionResult UploadFile()
        {
      
            return View();
        }

        /// <summary>
        /// Action for upload large file
        /// </summary>
        [HttpPost]
        [DisableRequestSizeLimit]
        [RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue)]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> UploadFile(UploadFile files)
        {
            var filesCount = Request?.Form?.Files?.Count ?? 0;
            if (files == null || filesCount == 0) {
                ModelState.AddModelError("NoFilesUploaded", $"No files slected and uploaded.Please upload files.");
                return View();
            }

            var request = HttpContext.Request;

            // validation of Content-Type
            // 1. first, it must be a form-data request
            // 2. a boundary should be found in the Content-Type
            if (!request.HasFormContentType ||
                !MediaTypeHeaderValue.TryParse(request.ContentType, out var mediaTypeHeader) ||
                string.IsNullOrEmpty(mediaTypeHeader.Boundary.Value)) {
                ModelState.AddModelError($"error", $"Something went wrong.");
                return View();
            }
            

            #region Filenames commented
            //var FileNamelist = new List<string> {
            //    "1_BENEFL_Integrated_Current_Import.csv",
            //    "2_BENEFL_Integrated_Prior_Import.csv",
            //    "3_DebitCard_Import.csv",
            //    "4_NPM.CSV",
            //    "5_QBdetail.xlsx",
            //    "6_BrokerClientlist.CSV",
            //    "7_Clientlist.CSV",
            //    "8_Cobraletters.CSV",
            //    "9_Bswift_BillingNumbers_Import.xlsx",
            //    "910_ENBillingNumbers_Import.xlsx",
            //    "911_EC Extract.txt",
            //    "912_EB Extract.txt",
            //    "913_SPMBYACAREPORT.CSV",
            //    "IgnoredRowsEBExtract.txt"
            //};
            #endregion

            var tblFilesNames = _db.TblFilesNameToUploads.ToList();
            //Seed FileNames

            var FileNamelist = tblFilesNames.Select(o => o.FileName).ToList();
            var validFilesCount = FileNamelist.Count;
           // string missingFiles = "";
            List<string> returnvalue = new List<string>();
            var uploadfiles = Request.Form.Files.Select(x => x.FileName).ToList();
          

            for (int i = 0; i < uploadfiles.Count; i++) {
                returnvalue.Add(Path.GetFileNameWithoutExtension(uploadfiles[i]));
            }

            var missingFile = tblFilesNames.Where(f => !returnvalue.Any(str => str.Contains(f.FileName)));
            //File count validation
            if (Request.Form.Files.Count != validFilesCount) {
                ModelState.AddModelError("file_count", $"Number of files to be uploaded should be {validFilesCount}.");
                ViewBag.missingFile = missingFile;
                //var missingFiles validation
                //for (int i = 0; i < uploadfiles.Count; i++) {
                //    bool exist = FileNamelist.Contains(uploadfiles[i])
                //}
                return View();
            }

            
            //File name,Size validation 
            string[] arr;
            string filePath;
            var IsValidationPassed = true;

            for (int i = 0; i < Request.Form.Files.Count; i++) {
                arr = Request.Form.Files[i].FileName.Split('.');
                arr[1] = "." + arr[1];
                var fileEntityObj = tblFilesNames.Where(o => o.FileName == arr[0] && o.FileExtension.ToLower() == arr[1].ToLower()).FirstOrDefault();
                if (fileEntityObj == null) {
                    ModelState.AddModelError($"{Request.Form.Files[i].FileName}NotFound", $"File {Request.Form.Files[i].FileName} can not upload due to invalid file name.");
                    IsValidationPassed = false;
                }
                //} else {
                //    if (Request.Form.Files[i].Length > 1000000 * fileEntityObj.MaxSizeInMb) {
                //        ModelState.AddModelError($"{Request.Form.Files[i].FileName + 'S'}", $"File {Request.Form.Files[i].FileName} can not upload because file size is greater than {fileEntityObj.MaxSizeInMb} Mb.");
                //        IsValidationPassed = false;
                //    } 
                //}
            }

            //rootpath = Path.Combine(rootpath, "wwwroot");
            //rootpath = Path.Combine(rootpath, "UserId_Name");
            //rootpath = Path.Combine(rootpath, "1_Ram");
            string rootpath = _env.ContentRootPath;
            rootpath = @"E:\Finance_Billing\Starting_Files";
            if (!Directory.Exists(rootpath)) {
                ModelState.AddModelError($"Something", $"Something went wrong.");
                //Directory.CreateDirectory(rootpath);
            }

            //checking vallidation is passed or not
            if (IsValidationPassed) {

                for (int i = 0; i < Request.Form.Files.Count; i++) {
                    filePath = Path.Combine(rootpath, Request.Form.Files[i].FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                        Request.Form.Files[i].CopyTo(fileStream);
                    }
                }

                //call the store procedure to run SSIS package
                SqlConnection sqlCon = null;
                Guid NewGuid = new Guid();
                //var getGuid = NewGuid.ToString();
                String SqlconString = _config.GetConnectionString("SqlConnectionString");
                using (sqlCon = new SqlConnection(SqlconString)) {
                    sqlCon.Open();
                    SqlCommand sql_cmnd = new SqlCommand("dbo.EXECUTE_SSIS_FINANCEBILLING", sqlCon);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@inputParameter", SqlDbType.NVarChar).Value = NewGuid.ToString();
                    // sql_cmnd.Parameters.AddWithValue("@output_execution_id", SqlDbType.NVarChar).Value = NewGuid.ToString();
                    SqlParameter parm3 = new SqlParameter("@output_execution_id", SqlDbType.Int);
                    parm3.Direction = ParameterDirection.Output;
                    sql_cmnd.Parameters.Add(parm3);
                    var lblsmsg = sql_cmnd.ExecuteNonQuery();
                    if (lblsmsg > 0) {
                        ViewBag.Message = "File uploaded successfully";
                        ViewBag.color = "Green";

                    } else {
                        ViewBag.Message = "Failed to upload file, Please check and try again.";
                        ViewBag.color = "Red";
                    }
                    sql_cmnd.ExecuteNonQuery();
                    sqlCon.Close();
                }

                //Check the errors in error table fetch and show to the end user.
                var packageerrors = _db.TblErrorLogs.ToList();

                for (int i = 0; i < packageerrors.Count; i++) {
                    ModelState.AddModelError(packageerrors[i].LogId.ToString(), packageerrors[i].ErrMsg.ToString());
                }

            }


            return View();
        }
    }

}
