using AutoMapper;
using DevExtremeAspNetCoreApp.Models;
using FinaceBilling.Models;
using FinanceBillingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Custom.Helpers
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

        }
    }
}
