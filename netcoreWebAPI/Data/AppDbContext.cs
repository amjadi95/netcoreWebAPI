using Microsoft.EntityFrameworkCore;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Commodity> Commodities { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
        {

        }
    }
    
}
