using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Dtos
{
    public class CommodityDeleteDto : DomainEntity
    {
        public string CommodityName { get; set; }

    }
}
