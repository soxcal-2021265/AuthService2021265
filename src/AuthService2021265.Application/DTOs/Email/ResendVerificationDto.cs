using System.ComponentModel.DataAnnotations;

namespace AuthService2021265.Application.DTOs.Email;

public class ResendVerificationDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set;} = string.Empty;
}