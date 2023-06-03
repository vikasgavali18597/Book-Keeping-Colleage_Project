namespace BookKeeper.Models
{
    public class GeneralLedger
    {
        public Guid Id { get; set; }

        public string GlNumber { get; set; }

        public Guid JournalEntryId { get; set; }

        public Guid AccountId { get; set; }

        public Guid ExplanationId { get; set; }

        public decimal Amount { get; set; }

        public string DrCr { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual JournalEntry JournalEntry { get; set; }

        public virtual Account Account { get; set; }

        public virtual Account Explanation { get; set; }
    }
}
