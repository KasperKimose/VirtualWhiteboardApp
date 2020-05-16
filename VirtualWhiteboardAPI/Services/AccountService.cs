using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Helpers;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DataAccess;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Services
{
    public class AccountService : IAccountService
    {

        private readonly VirtualWhiteboardContext _context;
        private readonly AppSettings _appSettings;

        private readonly IMapperService _mapperService;

        private readonly SHA256Managed _hasher;
        private readonly RNGCryptoServiceProvider _rngCsp;

        public AccountService(
            VirtualWhiteboardContext context, 
            IOptions<AppSettings> options,
            IMapperService mapperService
            )
        {
            _context = context;
            _appSettings = options.Value;

            _mapperService = mapperService;

            _hasher = new SHA256Managed();
            _rngCsp = new RNGCryptoServiceProvider();
        }

        public bool RegisterUser(RegisterUserDTO userDTO)
        {
            if (_context.Users.Any(u => u.Email.Equals(userDTO.Email)))
            {
                //todo: throw apiexception
                return false;
            }
            if(!userDTO.Password.Equals(userDTO.ConfirmPassword))
            {
                return false;
            }
            var team = _context.Teams.FirstOrDefault(t => t.Id == userDTO.TeamId);
            if (team == null)
            {
                return false;
            }

            var salt = GenerateSalt();
            var hashedPassword = Hash(userDTO.Password + salt);
            var user = new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                Password = hashedPassword,
                Salt = salt,
                MemberOf = team
            };
            _context.Users.Add(user);
            if (_context.SaveChanges() == 0)
            {
                return false;
            }
            return true;
        }

        public string Login(LoginUserDTO userDTO)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == userDTO.Email);
            if (user != null)
            {
                var hashedPw = Hash(userDTO.Password + user.Salt);
                if (user.Password.Equals(hashedPw))
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var secret = Encoding.ASCII.GetBytes(_appSettings.JWTSecret);
                    var tokenDescripter = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                    new Claim(ClaimTypes.Email, user.Email),
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescripter);
                    return tokenHandler.WriteToken(token);
                }
            }
            return null;
        }

        public UserDTO Get(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email.Equals(email));
            return _mapperService.Map(user);
        }

        private string GenerateSalt()
        {
            var byteArr = new byte[256];
            _rngCsp.GetBytes(byteArr);
            var salt = BitConverter.ToString(byteArr);
            return salt;
        }

        private string Hash(string password)
        {
            var byteArr = Encoding.UTF8.GetBytes(password);
            var hashBytes = _hasher.ComputeHash(byteArr);
            return Convert.ToBase64String(hashBytes);
        }

        private string EscapeName(string name)
        {
            return name.Trim('<', '>', '{', '}');
        }
    }
}
