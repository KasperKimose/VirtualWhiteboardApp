using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Services
{
    public interface IAccountService
    {
        bool RegisterUser(RegisterUserDTO userDTO);
        string Login(LoginUserDTO userDTO);
    }
}
