namespace BookKeeper.DTO
{
    public class JournalEntryDTO
    {
        public string Narration { get; set; } = string.Empty;

        public string GLNumber { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Guid DrAccountId { get; set; }

        public Guid CrAccountId { get; set; }

        public AccountDTO DrAccount { get; set; }

        public AccountDTO CrAccount { get; set; }

    }
}
