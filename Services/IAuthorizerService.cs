using F1API.DTOs;

namespace F1API.Services
{
    public interface IAuthorizerService
    {
        string GenerateToken(UserDTO user);
    }
}