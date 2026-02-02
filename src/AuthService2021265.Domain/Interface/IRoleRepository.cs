using AuthService2021265.Domain.Entities;

namespace AuthService2021265.Domain.Interface;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNamesAsync(string userId);
}