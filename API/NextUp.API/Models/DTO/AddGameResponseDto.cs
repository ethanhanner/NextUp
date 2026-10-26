namespace NextUp.API.Models.DTO
{
    public class AddGameResponseDto
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string CoverImage { get; set; } = string.Empty;
        public decimal EstimatedLengthInHours { get; set; }
        public int MetacriticScore { get; set; }
        public bool Purchased { get; set; }
    }
}
