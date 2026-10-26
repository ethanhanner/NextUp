namespace NextUp.API.Models.Domain
{
    public class Review
    {
        public long Id { get; set; }
        public required string SystemPlayedOn { get; set; }
        public DateOnly DateReviewed { get; set; }
        public string Thoughts { get; set; } = string.Empty;
        public decimal Rating { get; set; }

        public long? GameId { get; set; }
        public Game Game { get; set; } = null!;
    }
}
