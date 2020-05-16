using System.Collections.Generic;
using System.Security.Claims;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO;

namespace VirtualWhiteboardAPI.Services
{
    public interface IWhiteboardService
    {
        Post CreatePost(IEnumerable<Claim> claims, PostDTO postDTO);
    }
}
