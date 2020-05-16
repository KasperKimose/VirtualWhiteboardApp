using System.Collections.Generic;
using VirtualWhiteboardAPI.Models.DTO.User;

namespace VirtualWhiteboardAPI.Models.DTO.Team
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public IEnumerable<UserDTO> Members { get; set; }
        public Whiteboard Whiteboard { get; set; }
    }
}
