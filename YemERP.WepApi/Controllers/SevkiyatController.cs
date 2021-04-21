using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;

namespace YemERP.WepApi.Controllers
{
    public class SevkiyatController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SevkiyatController(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }
        [HttpGet]
        public async Task<IEnumerable<NetsisIsemriTbl>> GetNetsisIsemriTbls() => await _context.NetsisIsemriTbls.ToListAsync();
       
    }
}
