using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class PutPlatDTO : PlatBaseDTO
    {
        public int Id { get; set; }
        public string? CuisinierId { get; set; }
        public bool Mange { get; set; }
        public string? OgreId { get; set; }
    }
}
