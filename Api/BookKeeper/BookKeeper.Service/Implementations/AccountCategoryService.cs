using AutoMapper;
using BookKeeper.DataStore;
using BookKeeper.DTO;
using BookKeeper.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Service.Implementations
{
    public class AccountCategoryService : IAccountCategoryService
    {
        private readonly BookKeeperDbContext _context;
        private readonly IMapper _mapper;
        public AccountCategoryService(BookKeeperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AccountCategoryDTO>> GetAccountCategoriesAsync()
        {
            var accountCategories = _context.AccountCategories.Include("Accounts").ToList();

            return _mapper.Map<List<AccountCategoryDTO>>(accountCategories);
        }
    }
}
