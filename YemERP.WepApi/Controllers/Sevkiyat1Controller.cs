using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sevkiyat1Controller : ControllerBase
    {
        private readonly ISevkiyat _sevkiyat;

        public Sevkiyat1Controller(ISevkiyat sevkiyat)
        {
            this._sevkiyat = sevkiyat;
        }
        [HttpGet]
        public IEnumerable<NetsisIsemriTbl> Get()
        {
            return _sevkiyat.GetList();

           
        }
    }
}
