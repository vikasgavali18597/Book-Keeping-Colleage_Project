using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Profiler
{
    public class CreditProfile : Profile
    {
        public CreditProfile()
        {
            CreateMap<Credit, CreditDTO>().ReverseMap();
        }
    }
}
