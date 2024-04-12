// AuthController.cs

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Server.Models;
using BlogApp.Server.Services.AuthenticationService;

namespace BlogApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<int>> Register(UserRegister request)
        {
            try
            {
                var userId = await _authService.UserRegister(new User { Email = request.Email }, request.Password);
                return Ok(userId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
