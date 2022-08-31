﻿using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Brands.Models;
using Core.Persistence.Paging;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand,CreatedBrandDto>().ReverseMap();
            CreateMap<Brand,CreateBrandCommand>().ReverseMap();
            CreateMap<IPaginate<Brand>,BrandListModel>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
            CreateMap<Brand,BrandGetByIdDto>().ReverseMap();
        }
    }
}
