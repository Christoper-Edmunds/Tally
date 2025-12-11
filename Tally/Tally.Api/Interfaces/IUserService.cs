using Tally.Api.DTO;
using Tally.Data.Entities;

namespace Tally.Api.Interfaces
{
    public interface IUserService
    {
        User? ValidateUser(string Email, string Password);
        User? ValidateRefreshToken(string refreshToken);
        void UpdateRefreshToken(int userId, string newRefreshToken);

        bool UserExists(string email);
        User? CreateUser(RegisterRequest request);
    }
}
