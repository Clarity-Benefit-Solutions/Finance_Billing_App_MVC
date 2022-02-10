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

namespace DevExtremeAspNetCoreApp.Controllers
{
    public class UploadFIleController : Controller
    {
        private IHostingEnvironment _env { get; set; }

        private Finance_BillingContext _db;

        public UploadFIleController(IHostingEnvironment env, Finance_BillingContext db)
        {
            _env = env;
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
        /// <remarks>
        /// Request to this action will not trigger any model binding or model validation,
        /// because this is a no-argument action
        /// </remarks>
        /// <returns></returns>
        [HttpPost]
        // [Route(nameof(UploadFile))]
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
            string rootpath = _env.ContentRootPath;

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

            //File count validation
            if (Request.Form.Files.Count != validFilesCount) {
                ModelState.AddModelError("file_count", $"Number of files to be uploaded should be {validFilesCount}.");
                //return View();
            }

            //File name,Size validation 
            string[] arr;
            string filePath;
            rootpath = Path.Combine(rootpath, "wwwroot");
            rootpath = Path.Combine(rootpath, "UserId_Name");
            rootpath = Path.Combine(rootpath, "1_Ram");
           
            if (!Directory.Exists(rootpath)) {
                Directory.CreateDirectory(rootpath);
            }
            for (int i = 0; i < Request.Form.Files.Count; i++) {
                arr = Request.Form.Files[i].FileName.Split('.');
                arr[1] = "." + arr[1];
                var fileEntityObj = tblFilesNames.Where(o => o.FileName == arr[0] && o.FileExtension.ToLower() == arr[1].ToLower()).FirstOrDefault();
                if (fileEntityObj == null) {
                    ModelState.AddModelError($"{Request.Form.Files[i].FileName}", $"File {Request.Form.Files[i].FileName} can not uploade due to invalid file name.");
                } else {
                    if (Request.Form.Files[i].Length > 1000000 * fileEntityObj.MaxSizeInMb) {
                        ModelState.AddModelError($"{Request.Form.Files[i].FileName + 'S'}", $"File {Request.Form.Files[i].FileName} can not upload because file size is greater than {fileEntityObj.MaxSizeInMb} Mb.");
                    } else {
                        filePath = Path.Combine(rootpath, Request.Form.Files[i].FileName);
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                            Request.Form.Files[i].CopyTo(fileStream);
                        }
                    }
                }
            }

            // If the code runs to this location, it means that no files have been saved
            return View();
        }
    }

}
