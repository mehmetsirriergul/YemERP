using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YemERP.WepApi.Models.Service
{
    public interface IService<TEntity> where TEntity:class
    {
        Task AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
