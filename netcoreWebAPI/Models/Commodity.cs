using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Models
{
    public class Commodity : DomainEntity
    {
        public Commodity()
        {
            DateCreated = DateTime.Now;
        }

        [Required]
        public string CommodityName { get; set; }

        [Required]
        public double Price { get; set; }

        public double DiscountPercentage => 0;





        public string Code { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
