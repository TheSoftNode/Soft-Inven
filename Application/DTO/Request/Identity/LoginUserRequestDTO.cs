using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request.Identity;

public class LoginUserRequestDTO
{
    //[EmailAddress]
    [Required]
    [RegularExpression("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+", ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Required]
    [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$", ErrorMessage = "Password must contain at least a Capital letter, a number, a special character and a small letter alphabet")]
    [MinLength(8), MaxLength(100)]
    public string Password { get; set; }
}
