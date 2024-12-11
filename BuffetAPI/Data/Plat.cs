namespace BuffetAPI.Data
{
    public class Plat
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public double? Prix { get; set; }
        public required int TypePlatId { get; set; }
        public TypePlat? TypePlat { get; set; }
        public string? CuisinierId { get; set; }
    }
}
