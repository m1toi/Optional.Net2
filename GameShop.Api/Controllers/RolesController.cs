using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Core.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/Roles")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<RoleResponseDto>> GetRoles()
        {
            return Ok(_roleService.GetAll());
        }

        [HttpPost]


        public IActionResult CreateRole([FromBody] RoleRequestDto role)
        {
            try
            {
                _roleService.Create(role);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

     

    }
}
