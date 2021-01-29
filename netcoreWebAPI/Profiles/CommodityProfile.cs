using AutoMapper;
using netcoreWebAPI.Dtos;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Profiles
{
    public class CommodityProfile : Profile
    {
        public CommodityProfile()
        {
            CreateMap<CommodityCreateDto, Commodity>();
            CreateMap<CommodityReadDto, Commodity>();
            CreateMap<Commodity, CommodityReadDto>();
            CreateMap<Commodity, CommodityDeleteDto>();
        }
    }
}
