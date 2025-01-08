using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class PlatBaseDTO
    {
        public required string Nom { get; set; }
        
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être un nombre positif ou nul.")]
        public double? Prix { get; set; }

        public required int TypePlatId { get; set; }
    }
}
