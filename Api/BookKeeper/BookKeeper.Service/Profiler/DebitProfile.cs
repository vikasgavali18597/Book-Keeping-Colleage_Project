using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Profiler
{
    public class DebitProfile : Profile
    {
        public DebitProfile()
        {
            CreateMap<Debit, DebitDTO>().ReverseMap();
        }
    }
}
