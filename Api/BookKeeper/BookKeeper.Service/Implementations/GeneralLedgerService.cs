using BookKeeper.DTO;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class GeneralLedgerService : IGeneralLedgerService
    {
        public Task<List<GeneralLedgerAccountDTO>> GetGeneralLdgerAccount()
        {
            throw new NotImplementedException();
        }

        public Task<List<List<GeneralLedgerAccountDTO>>> GetGeneralLedgerAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
