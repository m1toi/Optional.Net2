using GameShop.Core.Dtos.Request;
using GameShop.Core.Dtos.Response;
using GameShop.Core.Services;
using LibraryManagement.Core.Dtos.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
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

        public ActionResult<List<UserResponseDto>> GetAll()
        {
            return Ok(_userService.GetAll());
        }
        
    }
}
