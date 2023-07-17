using HotelProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUserListWithWorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserListWithWorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:45181/api/AppUserWorkLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserWithWorkLocationDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
