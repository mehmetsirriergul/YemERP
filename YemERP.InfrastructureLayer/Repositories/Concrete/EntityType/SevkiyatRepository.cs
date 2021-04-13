using System;
using System.Collections.Generic;
using System.Text;
using YemERP.DomainLayer.Entities.Concrete;
using YemERP.DomainLayer.Repositories.Interfaces.EntitiyType;
using YemERP.InfrastructureLayer.Context;
using YemERP.InfrastructureLayer.Repositories.Concrete.Base;

namespace YemERP.InfrastructureLayer.Repositories.Concrete.EntityType
{
    public class SevkiyatRepository:BaseRepository<Sevkiyat>,ISevkiyatRepository
    {
        public SevkiyatRepository(SevkiyatDbContext context):base(context)
        {

        }
    }
}
