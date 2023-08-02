using BookKeeper.DTO;

namespace BookKeeper.Service.Interfaces
{
    public interface IAccountCategoryService
    {
        Task<List<AccountCategoryDTO>> GetAccountCategoriesAsync();
    }
}
