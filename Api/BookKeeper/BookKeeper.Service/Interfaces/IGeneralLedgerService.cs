using BookKeeper.DTO;

namespace BookKeeper.Service.Interfaces
{
    public interface IGeneralLedgerService
    {
        Task<List<GeneralLedgerAccountDTO>> GetGeneralLdgerAccount();

        Task<List<List<GeneralLedgerAccountDTO>>> GetGeneralLedgerAccounts();
    }
}
