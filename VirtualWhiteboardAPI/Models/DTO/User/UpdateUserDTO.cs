using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWhiteboardAPI.Models.DTO.User
{
    public class UpdateUserDTO
    {
        [Required] public string OldPassword { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string ConfirmPassword { get; set; }
    }
}
