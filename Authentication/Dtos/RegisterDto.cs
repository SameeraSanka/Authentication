using System.ComponentModel.DataAnnotations;

namespace Authentication.Dtos
{
    public class RegisterDto
    {

        [Required]
        public string FullName { get; set; } = string.Empty;


        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public List<string>? Roles { get; set; }
    }
}
