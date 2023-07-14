using HotelProject.BusinessLayer.Abstract;
using HotelProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult UserListWithWorkLocation()
        {
            var values = _appUserService.TUserListWithWorkLocation();
            return Ok(values);
        }

    }
}
