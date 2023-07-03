using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                List<ApiBookingLocationSearchViewModel> model = new List<ApiBookingLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "8f2fcf637bmsh898d1e8f3247637p1cce8cjsn71991ae9a090" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<ApiBookingLocationSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            else
            {
                List<ApiBookingLocationSearchViewModel> model = new List<ApiBookingLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "8f2fcf637bmsh898d1e8f3247637p1cce8cjsn71991ae9a090" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<ApiBookingLocationSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            
        }
    }
}
