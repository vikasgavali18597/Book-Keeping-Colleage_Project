using BookKeeper.DTO;

namespace BookKeeper.Service.Interfaces
{
    public interface IAccountService
    {
        Task<List<AccountDTO>> GetAccountsAsync();
        Task<List<AccountDTO>> GetAccountsById(Guid id);
    }
}
