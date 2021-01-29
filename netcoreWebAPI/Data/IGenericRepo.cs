using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Data
{
    public interface IGenericRepo<Entity> where Entity : DomainEntity
    {
        Task<bool> SaveChanges();
        Task<Entity> Add(Entity entity);
        Task<IQueryable<Entity>> GetAll();
        Task<Entity> GetById(int id);
        Task<Entity> Delete(int id);


    }
}
