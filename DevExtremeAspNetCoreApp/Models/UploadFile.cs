using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinaceBilling.Entities;
using DevExtremeAspNetCoreApp.Entities;
using DevExtremeAspNetCoreApp.Custom.Attributes;
using Microsoft.AspNetCore.Http;

namespace DevExtremeAspNetCoreApp.Models
{
    public class UploadFile : IValidatableObject
    {
        [Required]
        [MaxFileSize(int.MaxValue)]
        [AllowedExtensions(new[] { "xls", "csv", "xlsx", "txt" })]
        public List<IFormFile> UploadedFiles { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var photo = ((UploadFile)validationContext.ObjectInstance).UploadedFiles;
            //var extension = Path.GetExtension(photo.FileName);
            //var size = photo.Length;

            //if (!extension.ToLower().Equals(".jpg"))
            //    yield return new ValidationResult("File extension is not valid.");

            //if (size > (5 * 1024 * 1024))44
            //    yield return new ValidationResult("File size is bigger than 5MB.");

            //Finance_BillingContext fb = new Finance_BillingContext();
            
           // var tb = tbs;
            //TBL_LOGGINGDB tb = new TBL_LOGGINGDB();
            //fb.TBL_LOGGINGDBs.Add(tb);
            //fb.SaveChanges();
            return new List<ValidationResult>();
        }
    }
}

