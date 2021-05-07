using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Models.Repository.Concrete
{
   public class SevkiyatRepository:Repository<NetsisIsemriTbl>,ISevkiyatRepository
    {
        public SevkiyatRepository(ApplicationDbContext dbContext):base(dbContext)
        {

        }
    }
}
