using AutoMapper;
using BookKeeper.DTO;
using BookKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Service.Profiler
{
    public class GeneralLedgerProfile : Profile
    {
        public GeneralLedgerProfile()
        {
            CreateMap<GeneralLedger, GeneralLedgerAccountDTO>().ReverseMap();
            CreateMap<GeneralLedger, GeneralLedgerDTO>().ReverseMap();
        }
    }
}
