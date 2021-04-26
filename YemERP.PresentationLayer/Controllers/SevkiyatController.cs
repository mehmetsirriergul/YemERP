using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YemERP.ApplicationLayer.Services.Interfaces;
using YemERP.DomainLayer.Entities.Concrete;

namespace YemERP.PresentationLayer.Controllers
{
    public class SevkiyatController : Controller
    {
       
        public async Task<IActionResult> SevkiyatListe()
        {
            List<NetsisIsemriTbl> netsisIsemriTbls = new List<NetsisIsemriTbl>();
            using (var httpClient=new HttpClient())

            {
                using var request= await httpClient.GetAsync("http://localhost:31106/api/sevkiyat1");
                string response = await request.Content.ReadAsStringAsync();
                netsisIsemriTbls = JsonConvert.DeserializeObject<List<NetsisIsemriTbl>>(response);
            }
            return View(netsisIsemriTbls);
        }
    }
}
