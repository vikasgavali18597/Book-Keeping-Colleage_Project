namespace BookKeeper.DTO
{
    public class JournalDTO
    {
        public string Narration { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Guid DrAccountId { get; set; }

        public Guid CrAccountId { get; set; }

    }
}
