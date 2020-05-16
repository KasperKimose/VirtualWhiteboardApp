using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Services
{
    public interface IAccountService
    {
        bool RegisterUser(RegisterUserDTO userDTO);
        string Login(LoginUserDTO userDTO);
        User Get(string email);
        User GetUserByClaims(IEnumerable<Claim> claims);
    }
}
