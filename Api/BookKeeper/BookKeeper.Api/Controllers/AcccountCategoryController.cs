using BookKeeper.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcccountCategoryController : ControllerBase
    {
        private readonly IAccountCategoryService _accountCategoryService;

        public AcccountCategoryController(IAccountCategoryService accountCategoryService)
        {
            _accountCategoryService = accountCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccountCategories()
        {
            try
            {
                return Ok(await _accountCategoryService.GetAccountCategoriesAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
