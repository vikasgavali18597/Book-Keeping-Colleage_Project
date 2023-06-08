using BookKeeper.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralLedgerController : ControllerBase
    {
        private readonly IGeneralLedgerService _ledgerService;

        public GeneralLedgerController(IGeneralLedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }



    }
}
