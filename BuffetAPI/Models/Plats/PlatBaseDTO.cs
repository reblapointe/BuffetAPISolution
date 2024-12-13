using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class PlatBaseDTO
    {
        public required string Nom { get; set; }
        public double? Prix { get; set; }
        public required int TypePlatId { get; set; }
    }
}
