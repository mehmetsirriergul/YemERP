using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.Repository.Concrete;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private SevkiyatRepository _sevkiyatRepository;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public ISevkiyatRepository Sevkiyats => _sevkiyatRepository = _sevkiyatRepository ?? new SevkiyatRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
