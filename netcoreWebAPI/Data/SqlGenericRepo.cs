using Microsoft.EntityFrameworkCore;
using netcoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebAPI.Data
{
    public class SqlGenericRepo<Entity> : IGenericRepo<Entity> where Entity : DomainEntity
    {
        private readonly AppDbContext _context;

        public SqlGenericRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Entity> Add(Entity entity)
        {
            if (entity != null)
            {
                _context.Add(entity);
                return entity;
            }
            return null;
        }

        public async Task<Entity> Delete(int id)
        {
            var dbset = _context.Set<Entity>();
            var item = dbset.FirstOrDefault(c => c.Id == id);
            if (item == null)
            {
                return null;
            }
            else
            {
                dbset.Remove(item);
                return item;
            }
        }

        public async Task<IQueryable<Entity>> GetAll()
        {
            var dbset = _context.Set<Entity>();
            return dbset.AsQueryable();
        }

        public async Task<Entity> GetById(int id)
        {
            var dbset = _context.Set<Entity>();
            try
            {
                var item = dbset.FirstOrDefault(c => c.Id == id);
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<bool> SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
