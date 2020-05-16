using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models.DataAccess;
using VirtualWhiteboardAPI.Models.DTO;

namespace VirtualWhiteboardAPI.Services
{
    public class WhiteboardService : IWhiteboardService
    {
        private readonly VirtualWhiteboardContext _context;

        private readonly IAccountService _accountService;

        public WhiteboardService(
            VirtualWhiteboardContext context,
            IAccountService accountService
            )
        {
            _context = context;
            _accountService = accountService;
        }

        public void CreatePost(IEnumerable<Claim> claims, PostDTO postDTO)
        {
            var user = _accountService.GetUserByClaims(claims);
            throw new NotImplementedException();
        }
    }
}
