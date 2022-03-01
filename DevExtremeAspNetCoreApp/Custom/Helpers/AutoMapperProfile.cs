using AutoMapper;
using DevExtremeAspNetCoreApp.Entities;
using DevExtremeAspNetCoreApp.Models;
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
            //CreateMap<Customer, CustomerViewModel>().ReverseMap();.
            CreateMap<VwNewClient, ClientViewModel>().ReverseMap();
            CreateMap<VwExistingClient, ClientViewModel>().ReverseMap();
            CreateMap<VwTerminatedClient, ClientViewModel>().ReverseMap();
            



        }
    }
}
