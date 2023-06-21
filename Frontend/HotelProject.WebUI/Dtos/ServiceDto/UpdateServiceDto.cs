using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen servis ikon linkini giriniz")]
        public string ServiceIcon { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen hizmet başlığı  giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter veri girişi yapınız")]
        public string Title { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen hizmet açıklaması  giriniz")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karakter veri girişi yapınız")]
        public string Description { get; set; }
    }
}
