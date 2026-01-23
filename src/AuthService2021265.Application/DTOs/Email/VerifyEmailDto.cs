using System.ComponentModel.DataAnnotations;

namespace AuthService2021265.Application.DTOs.Email;

public class VerifyEmailDto
{
    [Required]
    public string Token { get; set;} = string.Empty;
}