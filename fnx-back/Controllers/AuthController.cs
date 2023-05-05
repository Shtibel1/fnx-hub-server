using BL.Interfaces;
using BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace fnx_back.Controllers
{
    public class AuthController : _baseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthForm login)
        {
            try
            {
                var token = await _authService.LoginAsync(login);
                if (token != null)
                {
                    return Ok(new
                    {
                        Token = token
                    });
                }
                return BadRequest("FAILED_LOGIN");
            }
            catch (Exception)
            {

                return BadRequest("FAILED_LOGIN");
            }
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup(AuthForm signup)
        {
            try
            {
                var token = await _authService.SignupAsync(signup);
                if (token != null)
                {
                    return Ok(new
                    {
                        Token = token
                    });
                }
                return BadRequest("FAILED_SIGNUP");
            }
            catch (Exception)
            {

                return BadRequest("FAILED_SIGNUP");
            }
        }
    }
}
