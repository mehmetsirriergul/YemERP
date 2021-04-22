using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;

namespace YemERP.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sevkiyat1Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Sevkiyat1Controller(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }
        [HttpGet]
        public List<NetsisIsemriTbl> GetList()
        {
            return _context.NetsisIsemriTbls.ToList();
               
        }
    }
}
