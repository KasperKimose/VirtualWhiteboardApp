
using System.Collections.Generic;

namespace VirtualWhiteboardAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Members { get; set; }
        public Whiteboard Whiteboard { get; set; }
    }
}
