using Tally.Data.Entities;

namespace Tally.Api.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
        string GenerateRefreshToken(User user);
    }
}
