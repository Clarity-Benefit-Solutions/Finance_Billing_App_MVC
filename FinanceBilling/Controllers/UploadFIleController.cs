using AutoMapper;
using FinanceBilling.Custom.Attributes;
using FinanceBilling.Models;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingModel.Models;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBilling.Controllers
{
    public class UploadFIleController : Controller
    {
        private IHostingEnvironment _env { get; set; }

        private readonly IConfiguration _config;
        private readonly IFileNameRepository _iFileNameRepository;
        private readonly ILoggingdbRepository _iLoggingdbRepository;
        private readonly IErrorLogService _iErrorLogService;
        private readonly ICommonService _iCommonService;
        // private readonly IUploadService _iUploadService;
        private readonly IClientService _iclientService;
        private readonly IMapper _mapper;
        private readonly IAnalyticsService _iAnalyticsService;
        private readonly ITblLoggingService _itblLoggingService;
        private readonly IApplicationSettingService _iApplicationSettingService;

        public UploadFIleController(IMapper mapper, IHostingEnvironment env, IConfiguration config, IFileNameRepository iFileNameRepository,
            IErrorLogService iErrorLogService, ILoggingdbRepository iLoggingdbRepository,
            ICommonService iCommonService
            //, IUploadService iUploadService
            , IClientService iclientService
            , IAnalyticsService iAnalyticsService
            , ITblLoggingService itblLoggingService,
            IApplicationSettingService iApplicationSettingService
            )
        {
            _env = env;
            _config = config;
            _iFileNameRepository = iFileNameRepository;
            _iErrorLogService = iErrorLogService;
            _iCommonService = iCommonService;
            //_iUploadService = iUploadService;
            _iclientService = iclientService;
            _iAnalyticsService = iAnalyticsService;
            _mapper = mapper;
            _iLoggingdbRepository = iLoggingdbRepository;
            _itblLoggingService = itblLoggingService;
            _iApplicationSettingService = iApplicationSettingService;
        }


        [HttpGet]
        public IActionResult UploadFile()
        {
            UploadFile uploadFile = new UploadFile();
            uploadFile.NewClientViewModels = new List<NewClientViewModel>();
            uploadFile.ExistingClients = new List<ExistingClient>();
            uploadFile.TerminatedClients = new List<TerminatedClient>();
            uploadFile.clientToClientViewModels = new List<ClientToClientViewModel>();
            uploadFile.clientToProductViewModels = new List<ClientToProductViewModel>();
            uploadFile.ClientViewModels = new List<ClientViewModel>();

            //uploadFile.UploadFileErrorModels = new List<UploadFileErrorModel>();


            return View(uploadFile);
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
            UploadFile uploadFile = new UploadFile();
            string isUploadedProxcessRunning = "0";
            string uploadProcessName = _config.GetSection("SSISTiming:UploadProcessName").Value;
            bool readyForUpload= await _iApplicationSettingService.GetSSPApplicationSettingByName(uploadProcessName);
           
            if (readyForUpload)
            {
                //When proces is finished
                await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "1");
                string parentPackageName = _config.GetSection("SSISTiming:ParentPackageName").Value;
               
                var filesCount = Request?.Form?.Files?.Count ?? 0;
                if (files == null || filesCount == 0)
                {
                    ModelState.AddModelError("NoFilesUploaded", $"No files slected and uploaded.Please upload files.");
                    return View(uploadFile);
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
                    return View(uploadFile);
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
                    return View(uploadFile);
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
                    foreach (var file in Request.Form.Files)
                    {
                        filePath = Path.Combine(rootpath, file.FileName);
                        DirectoryInfo info = new DirectoryInfo(rootpath);
                        if (!info.Exists)
                        {
                            info.Create();
                        }

                        //using (FileStream outputFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read))
                        using (FileStream outputFileStream = System.IO.File.Create(filePath))
                        {
                            await file.CopyToAsync(outputFileStream);
                        }

                    }

                    //call the store procedure to run SSIS package
                    Guid newGuid = Guid.NewGuid();
                    string guid = newGuid.ToString();
                    List<TblLogging> tbleLogginList = await _iCommonService.ExecuteSSISPackage(guid);
                    TblLogging parentFile = tbleLogginList.Where(x => x.PackageName == parentPackageName).FirstOrDefault();
                    bool? isExecuted = parentFile?.IsSuccess;
                    if (parentFile != null)

                        if (isExecuted == true)
                        {
                            //When proces is finished
                            await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                            ViewBag.Message = "File Uploaded Successfully";

                            uploadFile.NewClientViewModels = new List<NewClientViewModel>();
                            uploadFile.ExistingClients = new List<ExistingClient>();
                            uploadFile.TerminatedClients = new List<TerminatedClient>();
                            uploadFile.clientToProductViewModels = new List<ClientToProductViewModel>();
                            uploadFile.clientToClientViewModels = new List<ClientToClientViewModel>();
                        }
                        else
                        {
                            ViewBag.Message = "Failed To Upload File, Please check and try again.";

                            if (parentFile?.IsSuccess == false)
                            {
                                List<TBLERRORLOGS> tblErrorLog = await _iErrorLogService.GetErrorLogsByGuId(guid);
                                // Delete Files from starting folder
                                System.IO.DirectoryInfo di = new DirectoryInfo(rootpath);

                                foreach (FileInfo file in di.GetFiles())
                                {
                                    file.Delete();
                                }

                                
                                //Check the errors in error table fetch and show to the end user.
                                //for (int i = 0; i < tblErrorLog.Count; i++)
                                //{
                                //    ModelState.AddModelError(tblErrorLog[i].ErrorCode.ToString(), tblErrorLog[i].ErrorDescription.ToString());
                                //}
                                if (tblErrorLog?.Count > 0)
                                {
                                    uploadFile.ErrorList = new List<ErrorLogViewModels>();
                                    uploadFile.ErrorList = tblErrorLog.Select(x => new ErrorLogViewModels()
                                    {
                                        ID = x.ID,
                                        ErrorCode = x.ErrorCode,
                                        ErrorDescription = x.ErrorDescription,
                                        LoggingDbID = x.LoggingDbID,
                                        MachineName = x.MachineName,
                                        PackageName = x.PackageName,
                                        TaskName = x.TaskName,
                                        Dated = x.Dated
                                    }).ToList();
                                }
                                //When proces is finished
                                await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                            }
                            else
                            {
                                //guid = "6d3f3a9d-9dca-48b2-aa37-c01c4a0a8cde //For Testing
                                List<UploadFileErrorModel> uploadFileErrorModel = new List<UploadFileErrorModel>();
                                List<ListFileError> listFileErrors = new List<ListFileError>();

                                //List<ErrorFileNameList> errorFileNameLists = new List<ErrorFileNameList>()

                                uploadFile.ErrorFileNameLists = await _itblLoggingService.GetLogsForAccordion(guid);
                                foreach (var item in uploadFile.ErrorFileNameLists)
                                {
                                    //UploadFileErrorModel uploadFileError = new UploadFileErrorModel();
                                    //uploadFileError = _itblLoggingService.GetAllLoggingByGuid(guid, (int?)item.ID).Result;
                                    //uploadFileErrorModel.Add(uploadFileError);
                                    ListFileError listFile = new ListFileError();
                                    listFile = _itblLoggingService.AllDataLogsForAccordion(guid, item.ID).Result;
                                    listFileErrors.Add(listFile);

                                    //uploadFile.BrokerClientListErrorsList = uploadFileError.BrokerClientListErrorsList

                                    //_mapper.Map(uploadFileError.BrokerClientListErrorsList, uploadFile.BrokerClientListErrorsList);
                                    //_mapper.Map(uploadFileError.SwiftBillingNumImportErrorsList, uploadFile.SwiftBillingNumImportErrorsList);
                                    //_mapper.Map(uploadFileError.StaggingQbDetailErrorsList, uploadFile.StaggingQbDetailErrorsList);
                                    //_mapper.Map(uploadFileError.StaggingNpmErrorsList, uploadFile.StaggingNpmErrorsList);
                                    //_mapper.Map(uploadFileError.SpabyacareportErrorsList, uploadFile.SpabyacareportErrorsList);
                                    //_mapper.Map(uploadFileError.PlanDocReportPriorErrorsList, uploadFile.PlanDocReportPriorErrorsList);
                                    //_mapper.Map(uploadFileError.PlanDocReportErrorsList, uploadFile.PlanDocReportErrorsList);
                                    //_mapper.Map(uploadFileError.EmployeeNavImportErrorsList, uploadFile.EmployeeNavImportErrorsList);
                                    //_mapper.Map(uploadFileError.EcExtractErrorsList, uploadFile.EcExtractErrorsList);
                                    //_mapper.Map(uploadFileError.EbExtractErrorsList, uploadFile.EbExtractErrorsList);
                                    //_mapper.Map(uploadFileError.DebitCardSummeryErrorsList, uploadFile.DebitCardSummeryErrorsList);
                                    //_mapper.Map(uploadFileError.CobraLettersErrorsList, uploadFile.CobraLettersErrorsList);
                                    //_mapper.Map(uploadFileError.ClientListErrorsList, uploadFile.ClientListErrorsList);

                                }
                                //ViewBag.uploadFileErrorModel = uploadFileErrorModel;
                                uploadFile.listFileErrors = listFileErrors;

                                //When proces is finished
                                await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                            }
                        }
                }
            }
            else {
                ModelState.AddModelError($"error", $"File upload is already in process. Please try after some time!");
                return View(uploadFile);
            }
            return View(uploadFile);
        }
    }
}
