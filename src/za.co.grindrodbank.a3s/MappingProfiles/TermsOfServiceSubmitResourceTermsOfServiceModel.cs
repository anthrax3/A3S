﻿using System;
using AutoMapper;
using za.co.grindrodbank.a3s.A3SApiResources;
using za.co.grindrodbank.a3s.Models;

namespace za.co.grindrodbank.a3s.MappingProfiles
{
    public class TermsOfServiceSubmitResourceTermsOfServiceModel : Profile
    {
        public TermsOfServiceSubmitResourceTermsOfServiceModel()
        {
            CreateMap<TermsOfServiceSubmit, TermsOfServiceModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Uuid));
            CreateMap<TermsOfServiceModel, TermsOfServiceSubmit>().ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Id));
        }
    }
}
