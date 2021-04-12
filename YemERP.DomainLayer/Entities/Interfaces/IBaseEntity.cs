using System;
using System.Collections.Generic;
using System.Text;
using YemERP.DomainLayer.Enums;

namespace YemERP.DomainLayer.Entities.Interfaces
{
    public interface IBaseEntity
    {
        DateTime CreateDate { get; set;}
        DateTime? UpdateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Status Status { get; set; }

    }
}
