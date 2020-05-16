using System.Collections.Generic;
using System.Security.Claims;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO.Post;

namespace VirtualWhiteboardAPI.Services
{
    public interface IWhiteboardService
    {
        IEnumerable<Post> Get(IEnumerable<Claim> claims);
        Post CreatePost(IEnumerable<Claim> claims, CreatePostDTO postDTO);
    }
}
