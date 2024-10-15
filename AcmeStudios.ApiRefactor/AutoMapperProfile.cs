using AutoMapper;
﻿using AcmeStudios.ApiRefactor.DAL.Entities;
using AcemStudios.ApiRefactor.Data.DTOs;

namespace AcemStudios.ApiRefactor
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudioItem, GetStudioItemDto>();
            CreateMap<AddStudioItemDto, StudioItem>();
            CreateMap<StudioItem, GetStudioItemHeaderDto>();
        }
    }
}