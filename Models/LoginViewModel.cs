using System.ComponentModel.DataAnnotations;

namespace test.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
