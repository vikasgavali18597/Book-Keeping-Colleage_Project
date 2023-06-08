using AutoMapper;
using BookKeeper.DataStore;
using BookKeeper.DTO;
using BookKeeper.Service.Interfaces;

namespace BookKeeper.Service.Implementations
{
    public class GeneralLedgerService : IGeneralLedgerService
    {

        private readonly BookKeeperDbContext _context;
        private readonly IMapper _Mapper;


        public GeneralLedgerService(BookKeeperDbContext context, IMapper mapper)
        {
            _context = context;
            _Mapper = mapper;
        }

        public async  Task<List<GeneralLedgerAccountDTO>> GetGeneralLdgerAccount(Guid id)
        {
            var generalLedgerAccount = _context.Ledgers.Where(l => l.Id == id).FirstOrDefault();
            var dto = _Mapper.Map<List<GeneralLedgerAccountDTO>>(generalLedgerAccount);
            return dto;
        }

        public async Task<List<List<GeneralLedgerAccountDTO>>> GetGeneralLedgerAccounts(List<Guid> ids)
        {
            var dtos = new List<List<GeneralLedgerAccountDTO>>();

            foreach(Guid id in ids)
            {
                var generalLedgerAccount = _context.Ledgers.Where(l => l.Id == id).FirstOrDefault();
                var dto = _Mapper.Map<List<GeneralLedgerAccountDTO>>(generalLedgerAccount);
                dtos.Add(dto);
            }

            return dtos;
        }
    }
}
