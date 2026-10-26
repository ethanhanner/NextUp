namespace NextUp.API.Models.DTO
{
    public class AddGameRequestDto
    {
        public required string Name { get; set; }
        public IFormFile? CoverImageFile { get; set; }
        public decimal EstimatedLengthInHours { get; set; }
        public int MetacriticScore { get; set; }
        public bool Purchased { get; set; }
    }
}
