using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YemERP.WepApi.Models.DTOs;

namespace YemERP.PresentationLayer.WebApiService
{
    public class ApiServices
    {
        private readonly HttpClient _httpClient;
        public ApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<SevkiyatDTOs>>GetAllAsync()
        {
            IEnumerable<SevkiyatDTOs> sevkiyatDTO;
            var response = await _httpClient.GetAsync("http://localhost:31106/api/sevkiyat1");
            if (response.IsSuccessStatusCode)
            {
                sevkiyatDTO = JsonConvert.DeserializeObject<IEnumerable<SevkiyatDTOs>>(await response.Content.ReadAsStringAsync());


            }
            else
            {
                sevkiyatDTO = null;
            }
            return sevkiyatDTO;

        }
    }
}
