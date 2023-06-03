using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Interfaces
{
    public interface IJournalEntryService
    {
        Task<string> AddJournalEntries(JournalEntryDTO journalDto);

        Task<JournalDTO> GetJournalEntries();

        Task DeleteJournalEntry(Guid id);

        Task UpdateJournalEntry(JournalDTO journalEntry);

        Task<List<JournalEntryDTO>> GetAllJournalEntries();
    }
}
