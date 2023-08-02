using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Profiler
{
    public class AccountProfile : Profile
    {

        public AccountProfile()
        {
            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<Account, AccountKeyDTO>().ReverseMap();
        }
    }
}
