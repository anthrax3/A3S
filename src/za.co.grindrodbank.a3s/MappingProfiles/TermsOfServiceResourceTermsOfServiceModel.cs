/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
namespace za.co.grindrodbank.a3s.MappingProfiles
{
    public class TermsOfServiceResourceTermsOfServiceModel
    {
        public TermsOfServiceResourceTermsOfServiceModel()
        {
            CreateMap<TermsOfServiceSubmit, TermsOfServiceModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Uuid));
            CreateMap<TermsOfServiceModel, TermsOfServiceSubmit>().ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Id));
        }
    }
}
