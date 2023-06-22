using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen adı giriniz")]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Lütfen soyadı giriniz")]
        public string Surname { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şehri giriniz")]
        public string City { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen maili giriniz")]
        public string Mail { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler birbiri ile uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
