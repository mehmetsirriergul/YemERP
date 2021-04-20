using System;
using System.Collections.Generic;
using System.Text;
using YemERP.DomainLayer.Entities.Interfaces;
using YemERP.DomainLayer.Enums;

namespace YemERP.DomainLayer.Entities.Concrete
{
    public class NetsisIsemriTbl 
    {
        public string PLAKA { get; set; }
        public string SIPARISNO { get; set; }
        public int SIPSIRANO { get; set; }
        public string MALNO { get; set; }
        public decimal MIKTAR { get; set; }
        public DateTime KAYITTARIHI { get; set; }
        public int INCEKEYNO { get; set; }
        public bool URETILDI { get; set; }
        public decimal KALANMIKTAR { get; set; }

        
    }
}
