using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;

namespace YemERP.WepApi.Models.Repository.Interfaces
{
    public interface ISevkiyat<TEntity> where TEntity:class
    {
        Task AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
