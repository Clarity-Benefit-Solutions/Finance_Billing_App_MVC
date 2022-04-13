using AutoMapper;
using FinanceBilling.Models;
using FinanceBilling.Models;
using FinanceBillingData.Entities;
using FinanceBillingModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceBilling.Custom.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VwNewClient, ClientViewModel>().ReverseMap();
            CreateMap<VwExistingClient, ClientViewModel>().ReverseMap();
            CreateMap<VwTerminatedClient, ClientViewModel>().ReverseMap();
            CreateMap<TblExcludedClientViewModel, TblExcludedClient>().ReverseMap();
            CreateMap<TblLogging, TblLoggingViewModel>().ReverseMap();
            CreateMap<SpExcludeClientData, TblExcludedClientViewModel>().ReverseMap();
            CreateMap<VwTerminatedClient, TerminatedClient>().ReverseMap();
            CreateMap<VwExistingClient, ExistingClient>().ReverseMap();
            CreateMap<ClientProductComparison, ClientToProductViewModel>().ReverseMap();
            CreateMap<ClientToClientComparison, ClientToClientViewModel>().ReverseMap(); 
            CreateMap<VwNewClient, NewClientViewModel>().ReverseMap();
            //
            //CreateMap<UploadFileErrorModel, UploadFile>().ReverseMap();
         
            //

        }
    }
}
