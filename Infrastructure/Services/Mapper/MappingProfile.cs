﻿using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerBasic>();
        }

    }
}
