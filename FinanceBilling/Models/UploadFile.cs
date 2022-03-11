using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreApp.Custom.Attributes;
using FinaceBilling.Models;
using Microsoft.AspNetCore.Http;

namespace DevExtremeAspNetCoreApp.Models
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

