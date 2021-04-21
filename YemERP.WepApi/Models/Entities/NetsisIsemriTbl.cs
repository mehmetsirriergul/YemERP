using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemERP.WepApi.Models.Concrete
{
    public class NetsisIsemriTbl 
    {
        public string PLAKA { get; set; }
        public string SIPARISNO { get; set; }
        public int SIPSIRANO { get; set; }
        public string MALNO { get; set; }
        public decimal MIKTAR { get; set; }
        public DateTime KAYITTARIHI { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int INCKEYNO { get; set; }
        public int URETILDI { get; set; }
        public decimal KALANMIKTAR { get; set; }

        
    }
}
