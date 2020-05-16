using Microsoft.AspNetCore.Mvc;
using VirtualWhiteboardAPI.Models.DTO;
using VirtualWhiteboardAPI.Models.DTO.User;
using VirtualWhiteboardAPI.Services;

namespace VirtualWhiteboardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapperService _mapperService;

        public AccountController(IAccountService accountService, IMapperService mapperService)
        {
            _accountService = accountService;
            _mapperService = mapperService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUserDTO userDTO)
        {
            var token = _accountService.Login(userDTO);
            if(token != null)
            {
                return Ok(new TokenDTO { AccessToken = token});
            }
            return Unauthorized();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserDTO userDTO)
        {
            if (_accountService.RegisterUser(userDTO))
            {
                var user = _accountService.Get(userDTO.Email);
                return Created("User is created", _mapperService.Map(user));
            }
            return BadRequest("User could not be created");
        }
    }
}
