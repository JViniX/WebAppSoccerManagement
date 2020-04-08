using System.ComponentModel.DataAnnotations;

namespace Julio_C_301016383.Models.ViewModels
{
    public class LoginModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
