using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Auth
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Le nom d'usager est requis")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public required string Password { get; set; }
    }
}
