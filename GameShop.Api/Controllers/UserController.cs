using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/Users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("/register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult Register([FromBody] UserRequestDto user)
        {
            try
            {
                _userService.RegisterUser(user);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<string> Login([FromBody] LoginRequestDto login)
        {
            try
            {
                string token = _userService.LoginUser(login);
                return Ok(token);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<UserResponseDto>> GetAll()
        {
            return Ok(_userService.GetAll());
        }


      
    }
}
