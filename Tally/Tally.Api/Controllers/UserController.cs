using Microsoft.AspNetCore.Mvc;
using Tally.Api.DTO;
using Tally.Api.Interfaces;
using Tally.Api.Services;

namespace Tally.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService; // Your user validation logic
        private readonly IJwtService _jwtService;   // Your JWT generation logic
        public UserController(
            ILogger<UserController> logger,
            IUserService userService,
            IJwtService jwtService
            )
        {
            _logger = logger;
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _userService.ValidateUser(request.Email, request.Password);
            if (user == null)
                return Unauthorized();

            var token = _jwtService.GenerateToken(user);
            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (_userService.UserExists(request.Email))
                return BadRequest("User already exists.");

            var user = _userService.CreateUser(request);
            if (user == null)
                return StatusCode(500, "User creation failed.");

            return Ok(new { Message = "User created successfully." });
        }
    }
}
