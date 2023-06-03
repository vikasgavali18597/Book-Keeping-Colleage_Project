using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Profiler
{
    public class JournalEntryProfile : Profile
    {
        public JournalEntryProfile()
        {
            CreateMap<JournalEntry, JournalDTO>().ReverseMap();
            CreateMap<JournalEntry, JournalEntryDTO>().ReverseMap();
        }
    }
}
