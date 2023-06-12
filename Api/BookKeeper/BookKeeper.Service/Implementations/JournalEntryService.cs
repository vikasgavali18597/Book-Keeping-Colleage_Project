using AutoMapper;
using BookKeeper.DataStore;
using BookKeeper.DTO;
using BookKeeper.Models;
using BookKeeper.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Service.Implementations
{
    public class JournalEntryService : IJournalEntryService
    {
        private readonly BookKeeperDbContext _context;
        private readonly IMapper _mapper;
        public JournalEntryService(BookKeeperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> AddJournalEntries(JournalDTO journalDto)
        {
            try
            {
                var journalEntry = _mapper.Map<JournalEntry>(journalDto);
                journalEntry.GlNumber = GetGLNumber();
                journalEntry.GeneralLedgers = SetLedger(journalDto, journalEntry.GlNumber);
                _context.JournalEntries.Add(journalEntry);
                await _context.SaveChangesAsync();
                return "Data added succsefully";
            }
           catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task DeleteJournalEntry(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JournalEntryDTO>> GetAllJournalEntries()
        {
            var entries = _context.JournalEntries.Include("DrAccount").Select(x => new JournalEntry {
                Id = x.Id,
                Amount = x.Amount,
                CrAccount= x.CrAccount,
                DrAccount = x.DrAccount,
                DrAccountId = x.DrAccountId,
                CrAccountId = x.CrAccountId,
                GlNumber = x.GlNumber,
                Narration = x.Narration,
                Date = x.Date
            });
            var dto = entries.Select(x => _mapper.Map<JournalEntryDTO>(x)).ToList();

            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            return dto;
        }

        public Task<JournalDTO> GetJournalEntries()
        {
            throw new NotImplementedException();
        }

        public Task UpdateJournalEntry(JournalDTO journalEntry)
        {
            throw new NotImplementedException();
        }


        #region private methods
        
        private List<GeneralLedger> SetLedger(JournalDTO journalEntryDTO, string glnumber)
        {
            var createdDate = DateTime.Now;
            var leders = new List<GeneralLedger>();

            var dEntry = new GeneralLedger
            {
                AccountId = journalEntryDTO.DrAccountId,
                ExplanationId = journalEntryDTO.CrAccountId,
                CreatedDate = createdDate,
                Amount = journalEntryDTO.Amount,
                DrCr = "D",
                Date = journalEntryDTO.Date, 
                GlNumber = glnumber
            };

            var cEntry = new GeneralLedger
            {
                AccountId = journalEntryDTO.CrAccountId,
                ExplanationId = journalEntryDTO.DrAccountId,
                CreatedDate = createdDate,
                Amount = journalEntryDTO.Amount,
                DrCr = "C",
                Date = journalEntryDTO.Date,
                GlNumber = glnumber
            };

            leders.Add(dEntry);
            leders.Add(cEntry);

            return leders;
        }


        private string GetGLNumber()
        {
            var journals = _context.JournalEntries.Select(x => x.Date).Where(x => x.Date > DateTime.Now.Date && x.Date <= DateTime.Now.Date.AddDays(1));
            var date = DateTime.Now.ToString("yyyyyMMdd");
            return "GL-"+ date + "-"+(journals.Count() +1);
            //GL-20230608-1
        }
        #endregion

    }
}
