namespace BookKeeper.Models
{
    public class Account : Base
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Description { get; set; }

        public Guid AccounCategoryId { get; set; }

        public virtual AccountCategory AccountCategory { get; set; }
    }
}
