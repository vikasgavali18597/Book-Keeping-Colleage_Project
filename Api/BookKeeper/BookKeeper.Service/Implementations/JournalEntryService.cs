using BookKeeper.DataStore;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class JournalEntryService : IJournalEntryService
    {
        private readonly BookKeeperDbContext _context;

        public JournalEntryService(BookKeeperDbContext context)
        {
            _context = context;
        }
    }
}
