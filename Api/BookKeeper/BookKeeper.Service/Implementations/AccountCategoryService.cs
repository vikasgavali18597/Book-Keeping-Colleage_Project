using BookKeeper.DataStore;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class AccountCategoryService : IAccountCategoryService
    {
        private readonly BookKeeperDbContext _context;
        public AccountCategoryService(BookKeeperDbContext context)
        {
            _context = context;
        }
    }
}
