using AutoMapper;
using SMS.Application.DTOs;
using SMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Store, StoreDto>();
            CreateMap<CreateStoreDto, Store>();
            CreateMap<Store, CreateStoreDto>();
            CreateMap<UpdateStoreDto, Store>();
            CreateMap<Store, UpdateStoreDto>();
        }
    }
}
