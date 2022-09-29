using System.ComponentModel.DataAnnotations;

namespace BilimkanaAmerican.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Не указан Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Не указан пароль")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? ReturnUrl { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
}
