﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinanceBilling.Custom.Attributes;
using FinanceBilling.Models;
using Financebilling.Custom.Attributes;
using Microsoft.AspNetCore.Http;
using FinanceBillingModel.Models;

namespace FinanceBilling.Models
{
    public class UploadFile : IValidatableObject
    {
        [Required]
        [MaxFileSize(int.MaxValue)]
        [AllowedExtensions(new[] { "xls", "csv", "xlsx", "txt" })]
        public List<IFormFile> UploadedFiles { get; set; }
        public List<NewClientViewModel> NewClientViewModels { get; set; }
        public List<ExistingClient> ExistingClients { get; set; }
        public List<TerminatedClient> TerminatedClients { get; set; }
        public List<Analytics> Analytics { get; set; }
        public List<ClientToProductViewModel> clientToProductViewModels { get; set; }
        public List<ClientToClientViewModel> clientToClientViewModels { get; set; }
        public List<ClientViewModel> ClientViewModels { get; set; }
        public IEnumerable<ErrorLogViewModels> ErrorList { get; set; }
        public List<UploadFileErrorModel> UploadFileErrorModels { get; set; }
        public List<ListFileError> listFileErrors { get; set; }

        
        public List<ErrorFileNameList> ErrorFileNameLists { get; set; }
        //Upload File Error Model 
        public List<BrokerClientListError> BrokerClientListErrorsList { get; set; }
        public List<SwiftBillingNumImportError> SwiftBillingNumImportErrorsList { get; set; }
        public List<StaggingQbDetailError> StaggingQbDetailErrorsList { get; set; }
        public List<StaggingNpmError> StaggingNpmErrorsList { get; set; }
        public List<SpabyacareportError> SpabyacareportErrorsList { get; set; }
        public List<PlanDocReportPriorError> PlanDocReportPriorErrorsList { get; set; }
        public List<PlanDocReportError> PlanDocReportErrorsList { get; set; }
        public List<EmployeeNavImportError> EmployeeNavImportErrorsList { get; set; }
        public List<EcExtractError> EcExtractErrorsList { get; set; }
        public List<EbExtractError> EbExtractErrorsList { get; set; }
        public List<DebitCardSummeryError> DebitCardSummeryErrorsList { get; set; }
        public List<CobraLettersError> CobraLettersErrorsList { get; set; }
        public List<ClientListError> ClientListErrorsList { get; set; }
        //



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var photo = ((UploadFile)validationContext.ObjectInstance).UploadedFiles;
            //var extension = Path.GetExtension(photo.FileName);
            //var size = photo.Length;

            //if (!extension.ToLower().Equals(".jpg"))
            //    yield return new ValidationResult("File extension is not valid.");

            //if (size > (5 * 1024 * 1024))
            //    yield return new ValidationResult("File size is bigger than 5MB.");

              return new List<ValidationResult>();
        }
    }
}

