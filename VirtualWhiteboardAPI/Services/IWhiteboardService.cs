using System.Collections.Generic;
using System.Security.Claims;
using VirtualWhiteboardAPI.Models.DTO;

namespace VirtualWhiteboardAPI.Services
{
    public interface IWhiteboardService
    {
        void CreatePost(IEnumerable<Claim> claims, PostDTO postDTO);
    }
}
