using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Repository.Interfaces;
using YemERP.WepApi.Models.UnitOfWork;

namespace YemERP.WepApi.Models.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity; 
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int INCKEYNO)
        {
            return await _repository.GetByIdAsync(INCKEYNO);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
            _unitOfWork.Commit();
        }

        public TEntity Update(TEntity entity)
        {
            TEntity updateentity = _repository.Update(entity);
            _unitOfWork.CommitAsync();
            return updateentity;
        }

        //public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate) => await _repository.Where(predicate);
    }
}
