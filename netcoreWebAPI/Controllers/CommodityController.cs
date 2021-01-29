using Microsoft.AspNetCore.Mvc;
using netcoreWebAPI.Data;
using netcoreWebAPI.Models;
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
        private readonly IGenericRepo<Commodity> _commodityRepo;
        public CommodityController(IGenericRepo<Commodity> commodityRepo )
        {
            _commodityRepo = commodityRepo;
        }        

        [HttpPost]
        public async Task<IActionResult> Add( [FromBody]Commodity newCommodity)
        {
            await _commodityRepo.Add(newCommodity);
            await _commodityRepo.SaveChanges();
            return Ok(await _commodityRepo.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _commodityRepo.GetAll());
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _commodityRepo.GetById(id);

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _commodityRepo.Delete(id);
            await _commodityRepo.SaveChanges();

            return Ok(item);
        }
    }
}
