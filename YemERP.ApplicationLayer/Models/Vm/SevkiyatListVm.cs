using System;
using System.Collections.Generic;
using System.Text;

namespace YemERP.ApplicationLayer.Models.Vm
{
    public class SevkiyatListVm
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
