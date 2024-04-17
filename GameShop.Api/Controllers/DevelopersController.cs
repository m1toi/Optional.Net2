using GameShop.Core.Dtos.Response;
using GameShop.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Api.Controllers
{
    [Route("api/Developers")]
    public class DevelopersController : ControllerBase
    {
        private readonly IDeveloperService _developerService;

        public DevelopersController(IDeveloperService developerService)
        {
            this._developerService = developerService;
        }

        [HttpGet]
        public ActionResult<List<DeveloperResponseDto>> GetDevelopers()
        {
            return Ok(_developerService.GetDevelopers());
        }
    }
    
}
