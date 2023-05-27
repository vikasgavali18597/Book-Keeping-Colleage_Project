namespace BookKeeper.Models
{
    public class Debit : Base
    {
        public string GlNumber { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Guid JournalEntryId { get; set; }

        public Guid AccountId { get; set; }

        public Guid ExplanationId { get; set; }

        public JournalEntry JournalEntry { get; set; }
        public virtual Account Account { get; set; }
        public virtual Account Explanation { get; set; }
    }
}
