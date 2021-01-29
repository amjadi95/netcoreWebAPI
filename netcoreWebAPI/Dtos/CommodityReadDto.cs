using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Dtos
{
    public class CommodityReadDto : DomainEntity
    {
        public String CommodityName{ get; set; }

        public int Price { get; set; }

        public int DiscountPercentage { get; set; }

    }
}
