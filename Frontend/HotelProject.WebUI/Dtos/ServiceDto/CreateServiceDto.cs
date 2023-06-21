using HotelProject.WebUI.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Lütfen servis ikon linkini giriniz")]
        public string ServiceIcon { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen hizmet başlığı  giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
