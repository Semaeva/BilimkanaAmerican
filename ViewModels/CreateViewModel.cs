using System.ComponentModel.DataAnnotations;

namespace BilimkanaAmerican.ViewModels
{
    public class CreateViewModel
    {
        public string? Email { get; set; }


        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

     
    }
}
