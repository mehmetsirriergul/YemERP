using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemERP.DomainLayer.Entities.Interfaces;
using YemERP.DomainLayer.Repositories.Interfaces.Base;
using YemERP.InfrastructureLayer.Context;

namespace YemERP.InfrastructureLayer.Repositories.Concrete.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly SevkiyatDbContext _context;
        protected DbSet<T> table;
        public BaseRepository(SevkiyatDbContext sevkiyatDbContext)
        {
            this._context = sevkiyatDbContext;
            table = _context.Set<T>();
        }
        public async Task Add(T entity) => await table.AddAsync(entity);
        

        public async Task<bool> Any(Expression<Func<T, bool>> expression)=> await table.AnyAsync(expression);


        public void Delete(T entity) => table.Remove(entity);


        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return await table.Where(expression).FirstOrDefaultAsync();
        }

        public async Task<List<T>> Get(Expression<Func<T, bool>> expression) => await table.Where(expression).ToListAsync();
        

        public async Task<List<T>> GetAll() => await table.ToListAsync();



        public async Task<T> GetById(int id) => await table.FindAsync(id);
       

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disableTracking = true)
        {
            IQueryable<T> query = table;
            if (disableTracking) query = query.AsNoTracking();//https://docs.microsoft.com/en-us/ef/core/querying/tracking
            //AsNoTracking; Entity Framework tarafından uygulamaların performansını optimize etmemize yardımcı olmak için geliştirilmiş bir fonksiyondur. İşlevsel olarak veritabanından sorgu neticesinde elde edilen nesnelerin takip mekanizması ilgili fonksiyon tarafından kırılarak, sistem tarafından izlenmelerine son verilmesini sağlamakta ve böylece tüm verisel varlıkların ekstradan işlenme yahut lüzumsuz depolanma süreçlerine maliyet ayrılmamaktadır.
            if (include != null) query = include(query);
            if (expression != null) query = query.Where(expression);
            if (orderBy != null) return await orderBy(query).Select(selector).ToListAsync();
            else return await query.Select(selector).ToListAsync();
        }

        public void Update(T entity) => _context.Entry<T>(entity).State = EntityState.Modified;
        
    }
}
