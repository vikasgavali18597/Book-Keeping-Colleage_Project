namespace BookKeeper.Models
{
    public class JournalEntry
    {
        public Guid Id { get; set; }

        public string GlNumber { get; set; } = string.Empty;

        public string Narration { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Guid DrAccountId { get; set; }

        public Guid CrAccountId { get; set; }

        public virtual Account DrAccount { get; set; }

        public virtual Account CrAccount { get; set; }

        public virtual ICollection<GeneralLedger> GeneralLedgers { get; set; }
    }
}
