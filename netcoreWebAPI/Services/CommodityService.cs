using netcoreWebAPI.Data;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Services
{
    public class CommodityService : SqlGenericRepo<Commodity>, ICommodityService
    {
        public CommodityService(AppDbContext context) : base(context)
        {

        }
        public async Task<Commodity> Add(Commodity item)
        {
            var obj = await base.Add(item);
            var success = await SaveChanges();
            Console.WriteLine(success);
            return obj;

        }

        public async Task<Commodity> Delete(int id)
        {
            var obj = await base.Delete(id);
            var success = await SaveChanges();
            Console.WriteLine(success);
            return obj;

        }

        public async Task<IQueryable<Commodity>> GetAll()
        {
            var list = await base.GetAll();
            return list;
        }

        public async Task<Commodity> GetById(int id)
        {
            var item = await base.GetById(id);
            return item;
        }
        public async Task<string> SaveChanges()
        {
            bool success = false;
            try
            {
                success = await base.SaveChanges();
                if (success)
                    return "saved successed";

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return "save failed";
        }
    }
}
