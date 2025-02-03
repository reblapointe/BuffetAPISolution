using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class PlatBaseDTO
    {
        [Required(ErrorMessage = "Le nom du plat est requis")]
        public required string Nom { get; set; }
        
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être un nombre positif ou nul.")]
        public double? Prix { get; set; }

        [Required(ErrorMessage = "Un plat doit avoir un type de plat ")]
        public required int TypePlatId { get; set; }
    }
}
