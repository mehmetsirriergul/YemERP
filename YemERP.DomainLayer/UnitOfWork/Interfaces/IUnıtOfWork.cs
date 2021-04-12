using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YemERP.DomainLayer.Repositories.Interfaces.EntitiyType;

namespace YemERP.DomainLayer.UnitOfWork.Interfaces
{
    public interface IUnıtOfWork:IAsyncDisposable
    {
        ISevkiyatRepository sevkiyat { get; }
        Task Commit();
        Task ExecuteSqlCommand(string sql, params object[] parameters);
    }
}
