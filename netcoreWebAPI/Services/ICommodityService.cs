using netcoreWebAPI.Data;
using netcoreWebAPI.Dtos;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public interface ICommodityService 
    {
        Task<ServiceResponse<CommodityReadDto>> Add(CommodityCreateDto entity);
        Task<ServiceResponse<IEnumerable<CommodityReadDto>>> GetAll();
        Task<ServiceResponse<CommodityReadDto>> GetById(int id);
        Task<ServiceResponse<CommodityDeleteDto>> Delete(int id);
    }
}
