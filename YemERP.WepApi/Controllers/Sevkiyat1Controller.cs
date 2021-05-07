using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.Context;
using YemERP.WepApi.Models.DTOs;
using YemERP.WepApi.Models.Repository.Interfaces;

namespace YemERP.WepApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class Sevkiyat1Controller : ControllerBase
    {
        private readonly ISevkiyatRepository _sevkiyat;
        private readonly IMapper _mapper;

        public Sevkiyat1Controller(ISevkiyatRepository sevkiyat,IMapper mapper)
        {
            this._sevkiyat = sevkiyat;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sevkiyats = await _sevkiyat.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<SevkiyatDTOs>>(sevkiyats));

           
        }
        [HttpPut]
        public IActionResult Update(SevkiyatDTOs sevkiyatDTOs)
        {
            var sevkiyat = _sevkiyat.Update(_mapper.Map<NetsisIsemriTbl>(sevkiyatDTOs));

            return Ok();
            
            
             
        }
    }
}
