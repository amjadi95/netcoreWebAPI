using Microsoft.AspNetCore.Mvc;
using netcoreWebAPI.Data;
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
        public async Task<IActionResult> Add( [FromBody]Commodity newCommodity)
        {
            await _commodityService.Add(newCommodity);
            return Ok(await _commodityService.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _commodityService.GetAll());
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _commodityService.GetById(id);

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _commodityService.Delete(id);

            return Ok(item);
        }
    }
}
