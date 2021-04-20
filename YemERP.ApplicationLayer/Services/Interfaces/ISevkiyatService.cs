using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YemERP.DomainLayer.Entities.Concrete;

namespace YemERP.ApplicationLayer.Services.Interfaces
{
    public interface ISevkiyatService
    {
        Task<IEnumerable<Sevkiyat>> GetAllSevkiyat();
    }
}
