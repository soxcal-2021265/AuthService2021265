using System.ComponentModel.DataAnnotations;

namespace AuthService2021265.Application.DTOs;

public class GetProfileByIdDto
{
    [Required(ErrorMessage = "El UserId es requerido")]
    public string UserI { get; set; } = string.Empty;
}