using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        
        public async Task<ActionResult<NetsisIsemriTbl>>Edit(int INCKEYNO)
        {
            NetsisIsemriTbl netsisIsemri = new NetsisIsemriTbl();
            using (var httpClient = new HttpClient())
            {
                using var request = await httpClient.GetAsync($"http://localhost:31106/api/sevkiyat1/{INCKEYNO}");
                string response = await request.Content.ReadAsStringAsync();
                netsisIsemri = JsonConvert.DeserializeObject<NetsisIsemriTbl>(response);
            }
            return View(netsisIsemri);
        }

        [HttpPut]
        public async Task<ActionResult<NetsisIsemriTbl>> Edit(NetsisIsemriTbl netsisIsemriTbl)
        {
            
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(netsisIsemriTbl), Encoding.UTF8, "application/json");
                using var request = await httpClient.PutAsync($"http://localhost:31106/api/sevkiyat1/{netsisIsemriTbl.INCKEYNO}", content);
                string response = await content.ReadAsStringAsync();
            }
            return RedirectToAction("SevkiyatListe");
        }
    }
}
