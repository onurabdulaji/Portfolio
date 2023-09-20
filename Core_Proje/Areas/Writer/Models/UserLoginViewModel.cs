using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanici Adi")]
        [Required(ErrorMessage = "Kullanici Adi Giriniz")]
        public string Username { get; set; }
        [Display(Name = "Sifreniz")]
        [Required(ErrorMessage = "Sifrenizi  Giriniz")]
        public string Password { get; set; }
    }
}
