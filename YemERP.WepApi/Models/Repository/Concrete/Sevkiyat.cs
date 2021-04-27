using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace YemERP.WepApi.Models.Repository.Concrete
{
    public class Sevkiyat : ISevkiyat

    {
        private readonly ApplicationDbContext _ctx;
        public Sevkiyat(ApplicationDbContext applicationDbContext)
        {
            this._ctx = applicationDbContext;
        }
        public string Create(NetsisIsemriTbl netsisIsemriTbl)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public NetsisIsemriTbl Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<NetsisIsemriTbl> GetList()
        {


            var result = _ctx.NetsisIsemriTbls.OrderByDescending(x=>x.KAYITTARIHI).Take(200).ToList();
            return result;
            
        }

        public void Update(NetsisIsemriTbl netsisIsemriTbl)
        {
            throw new NotImplementedException();
        }
    }
}
