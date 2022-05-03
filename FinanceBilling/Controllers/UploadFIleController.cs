using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using FinanceBilling.Custom.Attributes;
using FinanceBilling.Models;
using FinanceBillingData.Entities;
using FinanceBillingData.Interface;
using FinanceBillingModel.Models;
using FinanceBillingService.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
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
            try
            {
                UploadFile uploadFile = new UploadFile();
                string uploadProcessName = _config.GetSection("SSISTiming:UploadProcessName").Value;
                bool readyForUpload = await _iApplicationSettingService.GetSSPApplicationSettingByName(uploadProcessName);
                string  uploadedFilePath= _config.GetSection("SSISTiming:UploadingFilePath").Value;
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
                        await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
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

                    }

                    string rootpath = _env.ContentRootPath;
                    rootpath = uploadedFilePath;
                    if (!Directory.Exists(rootpath))
                    {
                        ModelState.AddModelError($"Something", $"Something went wrong.");
                    }


                    //checking vallidation is passed or not
                    if (IsValidationPassed)
                    {
                        int i = 0;
                        foreach (var formFile in Request.Form.Files)
                        {
                            try
                            {
                                if (formFile.Length > 0)
                                {

                                    // full path to file in temp location
                                    filePath = Path.Combine(rootpath, formFile.FileName);
                                    DirectoryInfo info = new DirectoryInfo(rootpath);
                                    if (!info.Exists)
                                    {
                                        info.Create();
                                    }
                                    i++;
                                    using (var stream = new FileStream(filePath, FileMode.Create))
                                    {
                                        await formFile.CopyToAsync(stream);
                                        await Task.Delay(1000);
                                        stream.Close();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                if (ex.Message.Contains("because it is being used by another process")) { }
                                else
                                {
                                    throw;
                                }
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
                                if (tbleLogginList.Sum(x => x.NumRowsNotInserted) > 0)
                                {
                                    ViewBag.Message = "File validation error occured.";
                                    // If validation errors occured
                                    List<TBLERRORLOGS> tblErrorLog = await _iErrorLogService.GetErrorLogsByGuId(guid);
                                    // Delete Files from starting folder
                                    System.IO.DirectoryInfo di = new DirectoryInfo(rootpath);
                                    foreach (FileInfo file in di.GetFiles())
                                    {
                                        file.Delete();
                                    }

                                    //When proces is finished
                                    List<UploadFileErrorModel> uploadFileErrorModel = new List<UploadFileErrorModel>();
                                    List<ListFileError> listFileErrors = new List<ListFileError>();
                                    uploadFile.ErrorFileNameLists = await _itblLoggingService.GetLogsForAccordion(guid);
                                    await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                                    return View(uploadFile);
                                }
                                else
                                {
                                    //when file is uploaded succesfully 
                                    await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                                    ViewBag.Message = "File Uploaded Successfully";

                                    uploadFile.NewClientViewModels = new List<NewClientViewModel>();
                                    uploadFile.ExistingClients = new List<ExistingClient>();
                                    uploadFile.TerminatedClients = new List<TerminatedClient>();
                                    uploadFile.clientToProductViewModels = new List<ClientToProductViewModel>();
                                    uploadFile.clientToClientViewModels = new List<ClientToClientViewModel>();

                                    return View(uploadFile);

                                }
                            }
                            else
                            {
                                //when package is not run then it displaye
                                ViewBag.Message = "Failed To Upload File, one or more error occured.";
                                //When proces is finished
                                await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                                List<TBLERRORLOGS> tblErrorLog = await _iErrorLogService.GetErrorLogsByGuId(guid);
                                // Delete Files from starting folder
                                System.IO.DirectoryInfo di = new DirectoryInfo(rootpath);

                                foreach (FileInfo file in di.GetFiles())
                                {
                                    file.Delete();
                                }
                                //Check the errors in error table fetch and show to the end user.
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
                            }
                    }
                }
                else
                {
                    await _iApplicationSettingService.UpdateApplicationSettingValueByName(uploadProcessName, "0");
                    ModelState.AddModelError($"error", $"File upload is already in process. Please try after some time!");
                    return View(uploadFile);
                }
                return View(uploadFile);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("because it is being used by another process")) { throw; }
                else
                {
                    throw;
                }
            }
        }

        [HttpGet]
        public async Task<object> GetAccordionData(DataSourceLoadOptions loadOptions, string Guid, int Id)
        {
            ListFileError listFile = new ListFileError();
            List<AccordionBodyData> accordionBodyData = new List<AccordionBodyData>();


            listFile = _itblLoggingService.AllDataLogsForAccordion(Guid, Id).Result;
            if (listFile.BrokerClientListErrorsList != null)
            {
                foreach (var item in listFile.BrokerClientListErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.SwiftBillingNumImportErrorsList != null)
            {
                foreach (var item in listFile.SwiftBillingNumImportErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.StaggingQbDetailErrorsList != null)
            {
                foreach (var item in listFile.StaggingQbDetailErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);

            }
            if (listFile.StaggingQbDetailErrorsList != null)
            {
                foreach (var item in listFile.StaggingQbDetailErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);

            }
            if (listFile.SpabyacareportErrorsList != null)
            {
                foreach (var item in listFile.SpabyacareportErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.PlanDocReportPriorErrorsList != null)
            {
                //var plandocReportPriorErrorList = listFile.PlanDocReportPriorErrorsList;
                foreach (var item in listFile.PlanDocReportPriorErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);

            }
            if (listFile.PlanDocReportErrorsList != null)
            {
                foreach (var item in listFile.PlanDocReportErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);

            }
            if (listFile.EmployeeNavImportErrorsList != null)
            {
                foreach (var item in listFile.EmployeeNavImportErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.EcExtractErrorsList != null)
            {
                foreach (var item in listFile.EcExtractErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.EbExtractErrorsList != null)
            {
                foreach (var item in listFile.EbExtractErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.DebitCardSummeryErrorsList != null)
            {
                foreach (var item in listFile.DebitCardSummeryErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.CobraLettersErrorsList != null)
            {
                foreach (var item in listFile.CobraLettersErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            if (listFile.ClientListErrorsList != null)
            {
                foreach (var item in listFile.ClientListErrorsList)
                {
                    AccordionBodyData accordionBody = new AccordionBodyData();
                    accordionBody.EntityAttributes = item.EntityAttributes;
                    accordionBody.ErrorColumn = item.ErrorColumn;
                    accordionBody.ErrorRowNo = item.ErrorRowNo;
                    accordionBody.ErrorDescription = item.ErrorDescription;
                    accordionBody.LoggingDbId = item.LoggingDbId;
                    accordionBody.PackageName = item.PackageName;
                    accordionBodyData.Add(accordionBody);
                }
                return DataSourceLoader.Load(accordionBodyData, loadOptions);
            }
            return DataSourceLoader.Load(accordionBodyData, loadOptions);
        }
    }





}



