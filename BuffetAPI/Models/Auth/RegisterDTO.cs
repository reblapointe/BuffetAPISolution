using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Auth
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Le nom d'usager est requis")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "L'adresse courriel est requise")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public string? Password { get; set; }
    }
}
