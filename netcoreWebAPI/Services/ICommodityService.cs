using netcoreWebAPI.Data;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public interface ICommodityService : IGenericRepo<Commodity>
    {
    }
}
