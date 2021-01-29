using netcoreWebAPI.Data;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public interface ICommodityService : IGenericRepo<Commodity>
    {
        Task<ServiceResponse<Commodity>> Add(Commodity entity);
        Task<ServiceResponse<IQueryable<Commodity>>> GetAll();
        Task<ServiceResponse<Commodity>> GetById(int id);
        Task<ServiceResponse<Commodity>> Delete(int id);
    }
}
