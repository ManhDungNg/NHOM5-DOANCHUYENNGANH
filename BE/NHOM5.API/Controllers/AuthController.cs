using Microsoft.AspNetCore.Mvc;
using NHOM5.API.DTOs.Auth;
using NHOM5.API.Services.Interfaces;
using System.Threading.Tasks;

namespace NHOM5.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Dòng này bắt buộc phải có để Swagger nhận diện
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")] // Dòng này báo cho Swagger biết đây là API tạo mới
        public async Task<IActionResult> Register([FromBody] RegisterDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var isSuccess = await _authService.RegisterAsync(request);
            if (!isSuccess)
                return Conflict(new { Message = "Email hoặc Số điện thoại đã được đăng ký!" });

            return StatusCode(201, new { Message = "Đăng ký thành công!" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var token = await _authService.LoginAsync(request);

            if (token == null)
                return Unauthorized(new { Message = "Tài khoản hoặc mật khẩu không chính xác!" });

            return Ok(new
            {
                Message = "Đăng nhập thành công",
                Token = token
            });
        }
    }
}