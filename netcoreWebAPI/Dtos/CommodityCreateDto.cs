using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Dtos
{
    public class CommodityCreateDto
    {
        [Required]
        public string CommodityName { get; set; }

        [Required]
        public int Price { get; set; }

        public int DiscountPercentage { get; set; }

        
    }
}
