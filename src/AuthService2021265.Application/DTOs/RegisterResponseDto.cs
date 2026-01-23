namespace AuthService2021265.Application.DTOs;

public class RegisterResponseDto
{
    public bool Succes { get; set; } = false;
    public UserResponseDto User { get; set; } = new();
    public string Message { get; set; } = string.Empty;
    public bool EmailVerificactionRequired { get; set; } = true;
}