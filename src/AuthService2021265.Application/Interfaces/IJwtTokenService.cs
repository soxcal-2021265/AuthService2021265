using AuthService2021265.Domain.Entities;

namespace AuthService2021265.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken (User user);
}