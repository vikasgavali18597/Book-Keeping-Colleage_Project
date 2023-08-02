using AutoMapper;
using BookKeeper.DataStore;
using BookKeeper.DTO;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly BookKeeperDbContext _context;
        private readonly IMapper _mapper;
        public AccountService(BookKeeperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AccountDTO>> GetAccountsAsync()
        {
            var accounts = _context.Accounts.ToList();
            return _mapper.Map<List<AccountDTO>>(accounts);
        }

        public async Task<List<AccountDTO>> GetAccountsById(Guid id)
        {
            var accounts = _context.Accounts.Where(x => x.AccounCategoryId == id || x.AccountCategory.Id == id).ToList();
            return _mapper.Map<List<AccountDTO>>(accounts);
        }
    }
}
