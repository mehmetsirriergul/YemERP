using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Models.UnitOfWork
{
    public interface IUnitOfWork
    {
        ISevkiyatRepository Sevkiyats { get; }
        Task CommitAsync();
        void Commit();
    }
}
