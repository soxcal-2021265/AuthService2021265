using AuthService2021265.Domain.Entities;

namespace AuthService2021265.Domain.Interface;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUserByRoleAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNamesAsync(string userId);
}