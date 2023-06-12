using BookKeeper.DTO;
using BookKeeper.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BookKeeper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {
        private readonly IJournalEntryService _journalService;
        public JournalEntryController(IJournalEntryService journalService)
        {
            _journalService = journalService;
        }

        [HttpPost]
        public async Task<IActionResult> AddJournalEntry(JournalDTO journalEntry)
        {
            try
            {
                return Ok( await _journalService.AddJournalEntries(journalEntry));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllJournals()
        {
            try
            {
                return Ok(await _journalService.GetAllJournalEntries());
            }
            catch(Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
