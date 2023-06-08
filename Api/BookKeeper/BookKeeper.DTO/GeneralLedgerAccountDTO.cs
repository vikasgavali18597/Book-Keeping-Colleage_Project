namespace BookKeeper.DTO
{
    public class GeneralLedgerAccountDTO
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

        public virtual JournalEntryDTO JournalEntry { get; set; }

        public virtual AccountDTO Account { get; set; }

        public virtual AccountDTO Explanation { get; set; }
    }
}
