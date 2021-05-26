using AutoMapper;
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
using YemERP.PresentationLayer.WebApiService;
using YemERP.WepApi.Models.DTOs;
using YemERP.WepApi.Models.Service;

namespace YemERP.PresentationLayer.Controllers
{
    public class SevkiyatController : Controller
    {
        private readonly IService<NetsisIsemriTbl> _sevkiyat;
        private readonly ApiServices _apiServices;
        private readonly IMapper _mapper;

        public SevkiyatController(IService<NetsisIsemriTbl> sevkiyat, IMapper mapper)
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
        public async Task<IActionResult> Update(int INCKEYNO)
        {
            var sevkiyat = await _sevkiyat.GetByIdAsync(INCKEYNO);
            return Ok(_mapper.Map<SevkiyatDTOs>(sevkiyat));
        }
        [HttpPut]
        public IActionResult Update(SevkiyatDTOs sevkiyatDTOs)
        {
            var sevkiyat = _sevkiyat.Update(_mapper.Map<NetsisIsemriTbl>(sevkiyatDTOs));

            return Ok();



        }
    }
}
