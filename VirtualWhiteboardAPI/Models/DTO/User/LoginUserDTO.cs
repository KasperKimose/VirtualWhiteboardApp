﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWhiteboardAPI.Models.DTO.User
{
    public class LoginUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
