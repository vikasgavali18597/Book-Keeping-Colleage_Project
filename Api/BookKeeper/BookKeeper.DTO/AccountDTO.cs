namespace BookKeeper.DTO
{
    public class AccountDTO
    { 
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Description { get; set; }

        public AccountCategoryDTO AccountCategory { get; set; }
    }
}
