using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YemERP.DomainLayer.Repositories.Interfaces.EntitiyType;
using YemERP.DomainLayer.UnitOfWork.Interfaces;
using YemERP.InfrastructureLayer.Context;
using YemERP.InfrastructureLayer.Repositories.Concrete.EntityType;

namespace YemERP.InfrastructureLayer.UnitOfWork
{
    public class UnitOfWork : IUnıtOfWork
    {
        private readonly SevkiyatDbContext _context;
        public UnitOfWork(SevkiyatDbContext sevkiyat)
        {
            this._context = sevkiyat;
        }
        private ISevkiyatRepository _sevkiyat;
      

        public ISevkiyatRepository sevkiyat => _sevkiyat ?? (_sevkiyat = new SevkiyatRepository(_context));

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        private bool isDispose = false;
        public async ValueTask DisposeAsync()
        {
            if (!isDispose)
            {
                isDispose = true;
                await DisposeAsync(true);
                GC.SuppressFinalize(this); //https://docs.microsoft.com/en-us/dotnet/api/system.gc.suppressfinalize?view=net-5.0, https://stackoverflow.com/questions/151051/when-should-i-use-gc-suppressfinalize
            }
        }
        protected async ValueTask DisposeAsync(bool disposing)
        {
            if (disposing) await _context.DisposeAsync();
        }

        //public async Task ExecuteSqlCommand(string sql, params object[] parameters) => await _context.Database.ExecuteSqlRawAsync(sql, parameters);


    }
}
