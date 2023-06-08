using BookKeeper.DTO;

namespace BookKeeper.Service.Interfaces
{
    public interface IGeneralLedgerService
    {
        Task<List<GeneralLedgerAccountDTO>> GetGeneralLdgerAccount(Guid id);

        Task<List<List<GeneralLedgerAccountDTO>>> GetGeneralLedgerAccounts(List<Guid> ids);
    }
}
