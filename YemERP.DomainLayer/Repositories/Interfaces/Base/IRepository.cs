using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemERP.DomainLayer.Entities.Interfaces;

namespace YemERP.DomainLayer.Repositories.Interfaces.Base
{
    public interface IRepository<T> where T:class
    {
        Task<List<T>> GetAll();
        Task<List<T>> Get(Expression<Func<T, bool>> expression);
        Task<T> GetById(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);

        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> selector,
                                                     Expression<Func<T, bool>> expression,
                                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                     Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                     bool disableTracking = true);


        Task<bool> Any(Expression<Func<T, bool>> expression);

    }
}
