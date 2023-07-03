using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5243/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<ResultBookingDto> GetByID(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5243/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                return values;
            }
            return null;
        }
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var client= _httpClientFactory.CreateClient();
            var values = await GetByID(id);
            if (values!=null)
            {
                values.Status = "Onaylandı";
                var jsonPutData = JsonConvert.SerializeObject(values);
                StringContent stringContent= new StringContent(jsonPutData,Encoding.UTF8,"application/json");
                var responsePutMessage = await client.PutAsync("http://localhost:5243/api/Booking/UpdateBooking", stringContent);
                if (responsePutMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();

            }
            return View();
        }
    }
}
