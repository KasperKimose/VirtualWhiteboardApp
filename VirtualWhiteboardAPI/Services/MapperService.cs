using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO.Post;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Services
{
    public class MapperService : IMapperService
    {
        public UserDTO Map(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }

        public User Map(UserDTO userDTO)
        {
            return new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email
            };
        }

        public PostDTO Map(Post post)
        {
            return new PostDTO { };
        }

        public IEnumerable<PostDTO> Map(IEnumerable<Post> posts)
        {
            throw new NotImplementedException();
        }
    }
}
