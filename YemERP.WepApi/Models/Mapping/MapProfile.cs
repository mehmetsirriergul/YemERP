using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;
using YemERP.WepApi.Models.DTOs;

namespace YemERP.WepApi.Models.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<NetsisIsemriTbl, SevkiyatDTOs>();
            CreateMap<SevkiyatDTOs, NetsisIsemriTbl>();
        }
    }
}
