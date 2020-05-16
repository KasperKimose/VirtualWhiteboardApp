using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO.Post;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Services
{
    public interface IMapperService
    {
        UserDTO Map(User user);
        User Map(UserDTO userDTO);

        PostDTO Map(Post post);
        IEnumerable<PostDTO> Map(IEnumerable<Post> posts);
    }
}
