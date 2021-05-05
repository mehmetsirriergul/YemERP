using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Models.Repository.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class

    {
        public readonly ApplicationDbContext _context;
        public readonly DbSet<TEntity> _dbSet;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            _dbSet = applicationDbContext.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
             return _dbSet.Where(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }


}
