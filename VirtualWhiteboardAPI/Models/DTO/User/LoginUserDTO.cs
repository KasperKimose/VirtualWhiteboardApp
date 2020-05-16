using System.ComponentModel.DataAnnotations;

namespace VirtualWhiteboardAPI.Models.DTO.User
{
    public class LoginUserDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
