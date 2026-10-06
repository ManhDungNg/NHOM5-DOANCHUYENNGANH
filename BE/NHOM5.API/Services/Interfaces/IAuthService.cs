using NHOM5.API.DTOs.Auth;
using System.Threading.Tasks;

namespace NHOM5.API.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDto request);
        Task<bool> RegisterAsync(RegisterDto request);
    }
}