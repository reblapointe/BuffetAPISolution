using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class DetailsPlatDTO : PlatBaseDTO
    {
        public int Id { get; set; }
        public bool Mange { get; set; }
        public string? OgreId { get; set; }
        public TypePlat? TypePlat { get; set; }
        public string? CuisinierId { get; set; }
    }
}
