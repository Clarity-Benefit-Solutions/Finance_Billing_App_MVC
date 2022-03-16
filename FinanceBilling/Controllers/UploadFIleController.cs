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
using FinanceBillingData.Interface;
using FinanceBillingData.Entities;
using FinanceBillingService.Interface;

namespace FinaceBilling.Controllers
{
    public class UploadFIleController : Controller
    {
        private IHostingEnvironment _env { get; set; }
        private Finance_BillingContext _db;
        private readonly IConfiguration _config;
        private readonly IFileNameRepository _iFileNameRepository;
        private readonly IErrorLogService _iErrorLogService;
        private readonly ICommonService _iCommonService;
        public UploadFIleController(IHostingEnvironment env, IConfiguration config, IFileNameRepository iFileNameRepository, IErrorLogService iErrorLogService, ICommonService iCommonService)
        {
            _env = env;
            _config = config;
            _iFileNameRepository = iFileNameRepository;
            _iErrorLogService = iErrorLogService;
            _iCommonService = iCommonService;
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

            List<TblFilesNameToUpload> tblFilesNames = await _iFileNameRepository.GetFileNamesList();
            //Seed FileNames

            var FileNamelist = tblFilesNames.Select(o => o.FileName).ToList();
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
                Guid newGuid = new Guid();
                bool isExecuted = await _iCommonService.ExecuteSSISPackage(newGuid.ToString());
                if (isExecuted)
                {
                    ViewBag.Message = "File Uploaded Successfully";
                }
                else
                {
                    ViewBag.Message = "Failed To Upload File, Please check and try again.";
                }
                //var testGuid = "d0a12815-c092-4624-a13f-52add69b57e2";
                //Check the errors in error table fetch and show to the end user.
                List<TblErrorLog> packageerrors = await _iErrorLogService.GetErrorLogs();

                //List<TBL_LOGGINGDB> loggindbList = _db.TBL_LOGGINGDBs.ToList();
                //List<TBLERRORLOGS> errorLogsList = _db.TBLERRORLOGSs.ToList();

                //var detailsError = from l in loggindbList join e in errorLogsList on l.Id equals e.LoggingDbID where l.Guid == newGuid.ToString() select l;


                for (int i = 0; i < packageerrors.Count; i++)
                {
                    ModelState.AddModelError(packageerrors[i].LogId.ToString(), packageerrors[i].ErrMsg.ToString());
                }

            }


            return View();
        }
    }

}
