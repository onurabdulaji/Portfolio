using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lutfen Adinizi  Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lutfen Adinizi  Girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lutfen ImageUrl  Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lutfen Kullanici Adi Girin")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lutfen Sifre Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lutfen Sifre Tekrar Girin")]
        [Compare("Password", ErrorMessage = "Sifreler Uyusmuyor")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lutfen Mail  Girin")]
        public string Mail { get; set; }
    }
}
