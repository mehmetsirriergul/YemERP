using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemERP.WepApi.Models.DTOs
{
    public class SevkiyatDTOs
    {
        public string PLAKA { get; set; }
        public string SIPARISNO { get; set; }
        
        public string MALNO { get; set; }
        public decimal MIKTAR { get; set; }
        public DateTime KAYITTARIHI { get; set; }
        public int INCKEYNO { get; set; }
        public int URETILDI { get; set; }
       
    }
}
