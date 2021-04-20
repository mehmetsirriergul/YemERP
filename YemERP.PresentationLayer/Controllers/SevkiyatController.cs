using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.ApplicationLayer.Services.Interfaces;

namespace YemERP.PresentationLayer.Controllers
{
    public class SevkiyatController : Controller
    {
        private readonly ISevkiyatService _sevkiyatService;
        public SevkiyatController(ISevkiyatService sevkiyatService)
        {
            this._sevkiyatService = sevkiyatService;
        }
        public IActionResult SevkiyatListe()
        {
            
            return _sevkiyatService.GetAllSevkiyat()
        }
    }
}
