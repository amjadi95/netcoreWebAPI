using AutoMapper;
using netcoreWebAPI.Data;
using netcoreWebAPI.Dtos;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public class CommodityService :  ICommodityService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepo<Commodity> _repo;

        public CommodityService(IMapper mapper,IGenericRepo<Commodity> repo) 
        {   
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<ServiceResponse<CommodityReadDto>> Add(CommodityCreateDto newitem)
        {
            
            var response = new ServiceResponse<CommodityReadDto>();
            if(newitem != null)
            {
                var commodity = _mapper.Map<Commodity>(newitem);
                var newCommodity = await _repo.Add(commodity);
                response.Success = await _repo.SaveChanges();
                response.Data = _mapper.Map<CommodityReadDto>(newCommodity);
                
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

        public Task<Commodity> Add(Commodity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<CommodityDeleteDto>> Delete(int id)
        {
            var response = new ServiceResponse<CommodityDeleteDto>();
            var commodity = await _repo.Delete(id);
            response.Data = _mapper.Map<CommodityDeleteDto>(commodity);
            if(response.Data != null)
            {
                response.Success = await _repo.SaveChanges();
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

        public async Task<ServiceResponse<IEnumerable<CommodityReadDto>>> GetAll()
        {
            var response = new ServiceResponse<IEnumerable<CommodityReadDto>>();

            var list =  await _repo.GetAll();
            response.Data = _mapper.Map<IEnumerable<CommodityReadDto>>(list);
            if (response.Data == null)
            {
                response.Success = false;
                response.Message = "no item found";
            }
            return response;
        }

        public async Task<ServiceResponse<CommodityReadDto>> GetById(int id)
        {
            var response = new ServiceResponse<CommodityReadDto>();
            var commodity = await _repo.GetById(id);
            response.Data = _mapper.Map<CommodityReadDto>(commodity);
            if (response.Data == null)
            {
                response.Success = false;
                response.Message = "no item found";
            }
            return response;
        }

    }
}
