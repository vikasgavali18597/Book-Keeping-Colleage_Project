namespace BookKeeper.DTO
{
    public class CreditDTO
    {
        public string GlNumber { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Guid AccountId { get; set; }

        public Guid ExplanationId { get; set; }
    }
}
