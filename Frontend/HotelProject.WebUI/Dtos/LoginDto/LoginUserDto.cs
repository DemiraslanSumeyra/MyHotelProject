using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }
    }
}
