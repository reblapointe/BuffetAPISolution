using BuffetAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BuffetAPI.Models.Plats
{
    public class PostPlatDTO : PlatBaseDTO
    {
        public bool Mange { get; set; }
        public string? OgreId { get; set; }
    }
}
