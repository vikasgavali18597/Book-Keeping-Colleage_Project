using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;

namespace BookKeeper.Service.Profiler
{
    public class AccountCategoryProfile : Profile
    {

        public AccountCategoryProfile()
        {
            CreateMap<AccountCategory, AccountCategoryDTO>().ReverseMap();
        }
    }
}
