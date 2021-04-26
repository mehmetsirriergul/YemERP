using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;

namespace YemERP.WepApi.Models.Repository.Interfaces
{
    public interface ISevkiyat
    {
        string Create(NetsisIsemriTbl netsisIsemriTbl);
        List<NetsisIsemriTbl> GetList();
        NetsisIsemriTbl Get(int id);
        void Update(NetsisIsemriTbl netsisIsemriTbl);
        void Delete(int id);
    }
}
