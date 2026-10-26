namespace NextUp.API.Models.Domain
{
    public class Game
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string CoverImage { get; set; } = string.Empty;
        public decimal EstimatedLengthInHours { get; set; }
        public int MetacriticScore { get; set; }
        public bool Purchased { get; set; }
        public bool Completed { get; set; }
        public string RollCredits { get; set; } = string.Empty;
        public string ReasonDropped { get; set; } = string.Empty;
        public string ReasonFinished { get; set; } = string.Empty;

        public Review? Review { get; set; }
    }
}
