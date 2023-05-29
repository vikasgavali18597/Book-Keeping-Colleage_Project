using BookKeeper.DataStore;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly BookKeeperDbContext _context;

        public AccountService(BookKeeperDbContext context)
        {
            _context = context;
        }
    }
}
