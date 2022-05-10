

using System.ComponentModel.DataAnnotations;

namespace LMS.WebAPI.Endpoints.Users
{
    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
