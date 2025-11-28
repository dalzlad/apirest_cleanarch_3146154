using System.ComponentModel.DataAnnotations;

namespace ApiEmpresa.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        public string UserName { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
