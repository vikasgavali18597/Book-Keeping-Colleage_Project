using BookKeeper.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAccountsById([FromRoute] Guid id)
        {
            try
            {
                return Ok(await _accountService.GetAccountsById(id));
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await _accountService.GetAccountsAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
