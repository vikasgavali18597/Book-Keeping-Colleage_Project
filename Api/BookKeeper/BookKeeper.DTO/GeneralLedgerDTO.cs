namespace BookKeeper.DTO
{
    public class GeneralLedgerDTO
    {
        public string Narration { get; set; }

        public Guid AccountId { get; set; }

        public Guid ExplanationId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }


    }
}
