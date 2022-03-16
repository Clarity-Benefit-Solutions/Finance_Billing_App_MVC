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
using System.Data;
using Microsoft.Extensions.Configuration;
using FinanceBillingService.Interface;
using FinanceBillingData.Entities;
using Newtonsoft.Json;
using System.Net;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Microsoft.Data.SqlClient;

namespace FinaceBilling.Controllers
{
    public class QuickbookController : Controller
    {
        private IHostingEnvironment _env { get; set; }

        private readonly IConfiguration _config;
        private readonly IErrorLogService _iErrorLogService;
        private readonly IFileNameService _iFileNameService;
        private readonly IQuickBookClientsServices _iQuickBookClientsServices;
        public QuickbookController(IHostingEnvironment env, IConfiguration config, IErrorLogService iErrorLogService, IFileNameService iFileNameService, IQuickBookClientsServices iQuickBookClientsServices)
        {
            _env = env;
            _config = config;
            _iErrorLogService = iErrorLogService;
            _iFileNameService = iFileNameService;
            _iQuickBookClientsServices = iQuickBookClientsServices;
        }



        [HttpGet]
        public IActionResult Quickbook()
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
        public async Task<IActionResult> Quickbook(UploadFile files)
        {
            var filesCount = Request?.Form?.Files?.Count ?? 0;
            if (files == null || filesCount == 0)
            {
                ModelState.AddModelError("NoFilesUploaded", $"No files slected and uploaded.Please upload files.");
                return View();
            }

            var request = HttpContext.Request;

            // validation of Content-Type
            // 1. first, it must be a form-data request
            // 2. a boundary should be found in the Content-Type
            if (!request.HasFormContentType ||
                !MediaTypeHeaderValue.TryParse(request.ContentType, out var mediaTypeHeader) ||
                string.IsNullOrEmpty(mediaTypeHeader.Boundary.Value))
            {
                ModelState.AddModelError($"error", $"Something went wrong.");
                return View();
            }


            List<TblFilesNameToUpload> tblFilesNames = await _iFileNameService.GetFileNamesList();
            //Seed FileNames

            List<string> FileNamelist = tblFilesNames.Select(o => o.FileName).ToList();
            var validFilesCount = FileNamelist.Count;
            // string missingFiles = "";
            List<string> returnvalue = new List<string>();
            var uploadfiles = Request.Form.Files.Select(x => x.FileName).ToList();


            for (int i = 0; i < uploadfiles.Count; i++)
            {
                returnvalue.Add(Path.GetFileNameWithoutExtension(uploadfiles[i]));
            }

            var missingFile = tblFilesNames.Where(f => !returnvalue.Any(str => str.Contains(f.FileName)));
            //File count validation
            if (Request.Form.Files.Count != validFilesCount)
            {
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

            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                arr = Request.Form.Files[i].FileName.Split('.');
                arr[1] = "." + arr[1];
                var fileEntityObj = tblFilesNames.Where(o => o.FileName == arr[0] && o.FileExtension.ToLower() == arr[1].ToLower()).FirstOrDefault();
                if (fileEntityObj == null)
                {
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
            // rootpath = ConfigurationManager.AppSettings["Path"].ToString();

            if (!Directory.Exists(rootpath))
            {
                ModelState.AddModelError($"Something", $"Something went wrong.");
                //Directory.CreateDirectory(rootpath);
            }

            //checking vallidation is passed or not
            if (IsValidationPassed)
            {

                for (int i = 0; i < Request.Form.Files.Count; i++)
                {
                    filePath = Path.Combine(rootpath, Request.Form.Files[i].FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        Request.Form.Files[i].CopyTo(fileStream);
                    }
                }

                //call the store procedure to run SSIS package
                SqlConnection sqlCon = null;
                Guid NewGuid = new Guid();
                String SqlconString = _config.GetConnectionString("SqlConnectionString");
                using (sqlCon = new SqlConnection(SqlconString))
                {
                    sqlCon.Open();
                    SqlCommand sql_cmnd = new SqlCommand("dbo.EXECUTE_SSIS_FINANCEBILLING", sqlCon);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@inputParameter", SqlDbType.NVarChar).Value = NewGuid.ToString();
                    // sql_cmnd.Parameters.AddWithValue("@output_execution_id", SqlDbType.NVarChar).Value = NewGuid.ToString();
                    SqlParameter parm3 = new SqlParameter("@output_execution_id", SqlDbType.Int);
                    parm3.Direction = ParameterDirection.Output;
                    sql_cmnd.Parameters.Add(parm3);
                    sql_cmnd.ExecuteNonQuery();
                    sqlCon.Close();
                }

                //Check the errors in error table fetch and show to the end user.
                List<TblErrorLog> packageerrors = await _iErrorLogService.GetErrorLogs();

                for (int i = 0; i < packageerrors.Count; i++)
                {
                    ModelState.AddModelError(packageerrors[i].LogId.ToString(), packageerrors[i].ErrMsg.ToString());
                }

            }


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> QuickbookClients()
        {
            List<TblQBClients> quickbookClientlist = new List<TblQBClients>();
            return View(quickbookClientlist);
        }
        [HttpPost]
        public async Task<TblQBClients> AddAndUpdateQuickBookClient(TblQBClients tblQBClients)
        {
            return await _iQuickBookClientsServices.AddAndUpdateQuickBookClient(tblQBClients);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllQuickBookClientList(DataSourceLoadOptions loadOptions)//(int take, int skip)
        {
            var result = DataSourceLoader.Load(await _iQuickBookClientsServices.GetAllQuickBookClientList(1000000000,0), loadOptions);
            var resultJson = JsonConvert.SerializeObject(result);
            return Content(resultJson, "application/json");
            //  return await _iQuickBookClientsServices.GetAllQuickBookClientList(0, 1000000000);
            //   return await _iQuickBookClientsServices.GetAllQuickBookClientList(take, skip);
        }
        [HttpPost]
        public async Task<TblQBClients> GetQuickBookClientById(int clientId)
        {
            return await _iQuickBookClientsServices.GetQuickBookClientById(clientId);
        }
        [HttpPost]
        public async Task<ActionResult> AddNewQuickBookClient(string values)
        {
            TblQBClients tblQBClients = new TblQBClients();                             // Creating a new item
            JsonConvert.PopulateObject(values, tblQBClients);
            // Populating the item with the values
            //if (!TryValidateModel(tblQBClients))                        // Validating the item
            //    return new OkObjectResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
            await _iQuickBookClientsServices.AddNewQuickBookClient(tblQBClients);
            return new OkObjectResult(HttpStatusCode.OK);
            //return await _iQuickBookClientsServices.AddNewQuickBookClient(tblQBClients);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateQuickBookClient(int key, string values)
        {
            TblQBClients tblQBClients = new TblQBClients();
            tblQBClients.ClientID = key;
            // Creating a new item

            JsonConvert.PopulateObject(values, tblQBClients);
            // Populating the item with the values
            //if (!TryValidateModel(tblQBClients))                        // Validating the item
            //    return new OkObjectResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
            await _iQuickBookClientsServices.UpdateQuickBookClient(tblQBClients);
            return new OkObjectResult(HttpStatusCode.OK);
            //return await _iQuickBookClientsServices.UpdateQuickBookClient(tblQBClients);
        }
        [HttpDelete]
        public async Task DeleteQuickBookClient(int key)
        {
             await _iQuickBookClientsServices.DeleteQuickBookClient(key);
        }
    }
}
