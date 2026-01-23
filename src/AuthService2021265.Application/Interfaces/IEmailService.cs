namespace AuthService2021019.Application.Interfaces;

public interface IEmailService
{
    Task sendEmailVerificationAsync(string email, string username, string token);
    Task SendPasswordResetAsync(string email, string username, string token);
    Task SendWelcomeEmailAsync(string email, string username);
}