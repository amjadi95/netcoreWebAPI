using Microsoft.AspNetCore.Mvc;
using netcoreWebAPI.Data;
using netcoreWebAPI.Dtos;
using netcoreWebAPI.Models;
using netcoreWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class CommodityController : Controller
    {
        private readonly ICommodityService _commodityService;
        public CommodityController(ICommodityService commodityService)
        {
            _commodityService = commodityService;
        }        

        [HttpPost]
        public async Task<IActionResult> Add( [FromBody]CommodityCreateDto newCommodity)
        {
            var response =  await _commodityService.Add(newCommodity);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _commodityService.GetAll();
            return Ok(response);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _commodityService.GetById(id);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _commodityService.Delete(id);

            return Ok(response);
        }
    }
}
