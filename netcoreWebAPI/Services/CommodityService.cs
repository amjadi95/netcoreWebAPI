using netcoreWebAPI.Data;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public class CommodityService : SqlGenericRepo<Commodity>, ICommodityService
    {
        public CommodityService(AppDbContext context) : base(context)
        {

        }
        public async Task<ServiceResponse<Commodity>> Add(Commodity item)
        {
            
            var response = new ServiceResponse<Commodity>();
            if(item != null)
            {
                response.Data = await base.Add(item);
                response.Success = await base.SaveChanges();
                if(response.Success)
                {
                    response.Message = "item saved successfully";                    
                }
                else
                {
                    response.Message = "save failed";
                }
                
            }
            else
            {
                response.Success = false;
                response.Message = "request data cant be null";
            }
            
            return response;

        }

        public async Task<ServiceResponse<Commodity>> Delete(int id)
        {
            var response = new ServiceResponse<Commodity>();
            response.Data = await base.Delete(id);
            if(response.Data != null)
            {
                response.Success = await base.SaveChanges();
                if(response.Success)
                {
                    response.Message = "item deleted successfully";
                }
                else
                    response.Message = "item delete failed";
            }
            else
            {
                response.Success = false;
                response.Message = "no item found";
            }

            return response;

        }

        public async Task<ServiceResponse<IQueryable<Commodity>>> GetAll()
        {
            var response = new ServiceResponse<IQueryable<Commodity>>();

            response.Data =  await base.GetAll();
            if(response.Data == null)
            {
                response.Success = false;
                response.Message = "no item found";
            }
            return response;
        }

        public async Task<ServiceResponse<Commodity>> GetById(int id)
        {
            var response = new ServiceResponse<Commodity>();
            response.Data = await base.GetById(id);
            if (response.Data == null)
            {
                response.Success = false;
                response.Message = "no item found";
            }
            return response;
        }
    }
}
