﻿namespace BookKeeper.Models
{
    public class JournalEntry : Base
    {
        public string GlNumber { get; set; } = string.Empty;

        public string Narration { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public virtual Debit Debit { get; set; }

        public virtual Credit Credit { get; set; }

    }
}