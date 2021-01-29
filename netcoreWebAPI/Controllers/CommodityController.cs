using Microsoft.AspNetCore.Mvc;
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
        List<Commodity> list = new List<Commodity> { 
            new Commodity {Id=1,CommodityName="asd"},
            new Commodity {Id=2,CommodityName="qweqwe"},
            new Commodity {Id=3,CommodityName="7qkkweqghsawe"}
        };

        [HttpPost]
        public async Task<IActionResult> Add( [FromBody]Commodity newCommodity)
        {
            list.Add(newCommodity);

            return Ok(list);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(list);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = list.FirstOrDefault(c => c.Id == id);

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = list.First(c => c.Id == id);
            list.Remove(item);

            return Ok(list);
        }
    }
}
